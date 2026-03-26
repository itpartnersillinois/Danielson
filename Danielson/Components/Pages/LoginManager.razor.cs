using Danielson.Authentication;
using Danielson.Data;
using Danielson.Data.Login;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrWhiteSpace(GuidString))
            {
                
                var (identity, role, studentEvaluationId) = await ((CustomAuthenticationStateProvider)CustomAuthenticationStateProvider).PullManually(Guid.Parse(GuidString));

                if (string.IsNullOrWhiteSpace(identity.UserName))
                {
                    Console.Error.WriteLine("Failed to retrieve user information from database for GUID: " + GuidString);
                    NavigationManager.NavigateTo("/Account/LogoutPassthrough");
                    return;
                }

                var existingUser = await SignInManager.UserManager.FindByNameAsync(identity.UserName);

                if (existingUser != null)
                {

                    // User already exists, ensure claims are up to date
                    var existingClaims = await SignInManager.UserManager.GetClaimsAsync(existingUser);
                    var roleClaim = existingClaims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
                    var studentEvalClaim = existingClaims.FirstOrDefault(c => c.Type == ClaimConstants.StudentEvaluationId);

                    if (roleClaim == null || roleClaim.Value != role)
                    {
                        if (roleClaim != null)
                        {
                            await SignInManager.UserManager.RemoveClaimAsync(existingUser, roleClaim);
                        }

                        await SignInManager.UserManager.AddClaimAsync(existingUser, new Claim(ClaimTypes.Role, role));

                    }
                    if (studentEvalClaim == null || studentEvalClaim.Value != studentEvaluationId)
                    {
                        if (studentEvalClaim != null)
                        {
                            await SignInManager.UserManager.RemoveClaimAsync(existingUser, studentEvalClaim);
                        }

                        await SignInManager.UserManager.AddClaimAsync(existingUser, new Claim(ClaimConstants.StudentEvaluationId, studentEvaluationId));
                    }

                    // Log user
                    await SignInManager.SignInAsync(existingUser, isPersistent: true);

                    // Update the authentication state to ensure the new claims are included in the user's identity
                    await SignInManager.RefreshSignInAsync(existingUser);

                } else {

                    // Create a new user in the database if they don't exist
                    var newUser = new ApplicationUser
                    {
                        UserName = identity.UserName,
                        Email = identity.Email
                    };

                    var createUser = await SignInManager.UserManager.CreateAsync(newUser);

                    if (!createUser.Succeeded)
                    {
                        Console.Error.WriteLine($"Failed to create user: {string.Join(", ", createUser.Errors.Select(e => e.Description))}");
                        NavigationManager.NavigateTo("/Account/LogoutPassthrough");
                        return;
                    }

                    // Store claims in the database
                    await SignInManager.UserManager.AddClaimAsync(newUser, new Claim(ClaimTypes.Role, role));
                    await SignInManager.UserManager.AddClaimAsync(newUser, new Claim(ClaimConstants.StudentEvaluationId, studentEvaluationId));

                    // Sign in with the persistent claims
                    await SignInManager.SignInWithClaimsAsync(
                        newUser,
                        isPersistent: true,
                        [
                            new(ClaimTypes.Role, role),
                        new(ClaimConstants.StudentEvaluationId, studentEvaluationId)
                        ]
                    );

                }


                NavigationManager.NavigateTo("/Form/Domain/" + studentEvaluationId);
            }
        }
    }
}