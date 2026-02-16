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

                var (identity, role, studentEvaluationId) =
                    await ((CustomAuthenticationStateProvider)CustomAuthenticationStateProvider)
                        .PullManually(Guid.Parse(GuidString));

                // Ensure the user exists in the Identity store
                var existingUser = await SignInManager.UserManager.FindByNameAsync(identity.UserName ?? "");

                if (existingUser is null) {
                    var newUser = new ApplicationUser { 
                        UserName = identity.UserName ?? "", 
                        Email = identity.Email ?? "",
                        EmailConfirmed = true // Assuming email is confirmed since it's coming from a trusted source
                    };

                    var createResult = await SignInManager.UserManager.CreateAsync(newUser);

                    if (!createResult.Succeeded) {

                        // Handle user creation failure
                        Console.Error.WriteLine($"Failed to create user: {string.Join(", ", createResult.Errors.Select(e => e.Description))}");

                        // Log the user out and redirect
                        NavigationManager.NavigateTo("/Account/LogoutPassthrough");
                    }

                    // Add role
                    await SignInManager.UserManager.AddToRoleAsync(newUser, role);

                    existingUser = newUser;
                }

                // Sign in the persisted user
                await SignInManager.SignInWithClaimsAsync(
                    existingUser,
                    isPersistent: false,
                    [
                    new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Role, role),
                    new System.Security.Claims.Claim(ClaimConstants.StudentEvaluationId, studentEvaluationId)
                    ]
                );

                NavigationManager.NavigateTo("/Form/Domain/" + studentEvaluationId);
            }
        }
    }
}