using System.Security.Claims;
using Danielson.Data;
using Danielson.Data.Login;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Danielson.Authentication {

    public class CustomAuthenticationStateProvider(ILoggerFactory loggerFactory, IServiceScopeFactory scopeFactory, IOptions<IdentityOptions> optionsAccessor, UserAccess userAccess) : RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>(loggerFactory, scopeFactory, optionsAccessor) {
        private readonly UserAccess _userAccess = userAccess;
        private ClaimsPrincipal? currentUser;

        public ClaimsPrincipal CurrentUser {
            get => currentUser ?? new();
            set {
                currentUser = value;
            }
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
            var authState = await base.GetAuthenticationStateAsync();
            var identity = (ClaimsIdentity?) authState.User.Identity;
            if (identity == null) {
                return authState;
            }
            var user = new ClaimsPrincipal(identity);
            currentUser = user;
            return new AuthenticationState(user);
        }

        public async Task<(IdentityUser, string role, string studentId)> PullManually(Guid guid) {
            var userFromDatabase = await _userAccess.Get(guid);
            var identity = userFromDatabase.username == "" ? new IdentityUser() : new IdentityUser(userFromDatabase.username) { Email = userFromDatabase.email };
            return (identity, userFromDatabase.role.ToString(), userFromDatabase.studentId);
        }
    }
}