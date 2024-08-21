using Danielson.Data;
using Danielson.Data.DataModels;
using Danielson.Data.Login;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Danielson.Components.Pages {

    public partial class LogoutManager {

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected SignInManager<ApplicationUser> SignInManager { get; set; } = default!;

        [Inject]
        protected UserAccess UserAccess { get; set; } = default!;
        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;
        protected override async Task OnInitializedAsync() {
            await SignInManager.SignOutAsync();
            var roleType = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            _ = Enum.TryParse(roleType, out RoleEnum role);
            NavigationManager.NavigateTo(UserAccess.TargetUrl[role]);
        }
    }
}