using Danielson.Data;
using Danielson.Data.DataModels;
using Danielson.Data.Login;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Danielson.Authentication
{

    public class CustomAuthenticationStateProvider(ILoggerFactory loggerFactory, IServiceScopeFactory scopeFactory, IOptions<IdentityOptions> optionsAccessor, UserAccess userAccess) 
        : RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>(loggerFactory, scopeFactory, optionsAccessor) {

        private readonly UserAccess _userAccess = userAccess;
        private ClaimsPrincipal? currentUser;

        public ClaimsPrincipal CurrentUser {
            get => currentUser ?? new();
            set
            {
                currentUser = value;
            }
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync() {

            // This method is called by the Blazor framework to get the current authentication state. We override it to add logging and to set the current user.
            // 1-HTTP Context/Cookies: The base implementation checks the current HTTP request's authentication cookie (typically the .AspNetCore.Identity.Application cookie).
            // 2-Claims Principal: It reconstructs a ClaimsPrincipal object from the authenticated user's claims stored in that cookie.

            var authState = await base.GetAuthenticationStateAsync();
            var identity = (ClaimsIdentity?) authState.User.Identity;

            if (identity == null) {
                return authState;
            }

            var user = new ClaimsPrincipal(identity);
            currentUser = user;

            return new AuthenticationState(user);
        }

        public async Task<(IdentityUser, string role, string studentEvaluationId)> PullManually(Guid guid) {
            // This method is used to pull the user information from the database manually, bypassing the normal authentication flow.
            var userFromDatabase = await _userAccess.Get(guid);

            var identity = userFromDatabase.username == "" 
                ? new IdentityUser() 
                : new IdentityUser(userFromDatabase.username) { Email = userFromDatabase.email };

            return (identity, userFromDatabase.role.ToString(), userFromDatabase.studentEvaluationId);
        }
    }
}