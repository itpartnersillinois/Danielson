using System.Security.Claims;
using Danielson.Authentication;
using Danielson.Data;
using Danielson.Data.Login;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Danielson.Components.Pages {

    public partial class LoginManager {

        [Parameter]
        public string? GuidString { get; set; } = "";

        [Inject]
        protected AuthenticationStateProvider CustomAuthenticationStateProvider { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected SignInManager<ApplicationUser> SignInManager { get; set; } = default!;

        [Inject]
        protected UserAccess UserAccess { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            if (!string.IsNullOrWhiteSpace(GuidString)) {
                var (newResult, role, studentId) = await ((CustomAuthenticationStateProvider) CustomAuthenticationStateProvider).PullManually(Guid.Parse(GuidString));
                var appUser = new ApplicationUser { Email = newResult.Email, UserName = newResult.UserName };
                await SignInManager.SignInWithClaimsAsync(appUser, true, [new(ClaimTypes.Role, role), new(ClaimConstants.StudentId, studentId)]);
                NavigationManager.NavigateTo("/");
            }
        }
    }
}