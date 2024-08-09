using Danielson.Data;
using Danielson.Data.Login;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace Danielson.Components.Pages {

    public partial class LogoutManager {

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected SignInManager<ApplicationUser> SignInManager { get; set; } = default!;

        [Inject]
        protected UserAccess UserAccess { get; set; } = default!;

        protected override async Task OnInitializedAsync() {
            await SignInManager.SignOutAsync();
            NavigationManager.NavigateTo(UserAccess.TargetUrl);
        }
    }
}