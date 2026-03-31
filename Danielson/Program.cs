using Danielson.Authentication;
using Danielson.Components;
using Danielson.Components.Account;
using Danielson.Data;
using Danielson.Data.Data;
using Danielson.Data.DataAccess;
using Danielson.Data.Login;
using Danielson.Data.PortalTranslator;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

builder.Services.AddDbContextFactory<FormContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection")).EnableSensitiveDataLogging(true));
builder.Services.AddScoped<FormRepository>();
builder.Services.AddScoped(s => new UserAccess(s.GetService<FormRepository>(), builder.Configuration["Testing"]));
builder.Services.AddScoped<FormTemplateAccess>();
builder.Services.AddScoped<FormAccess>();
builder.Services.AddScoped(s => new FormImport(builder.Configuration.GetConnectionString("AppConnection")));

builder.Services.AddAuthentication(options => {
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
.AddIdentityCookies();

// This ensures that the authentication cookie itself will expire after the specified time, which is important for scenarios where the user might be idle
// for a long period or if the SignalR connection is lost and needs to be re-established.
builder.Services.Configure<CookieAuthenticationOptions>(
    IdentityConstants.ApplicationScheme, 
    options => {
        options.ExpireTimeSpan = TimeSpan.FromHours(2);
        // With SlidingExpiration enabled, the cookie's expiration time will be reset on each request, effectively keeping the user logged in as long as they are active.
        options.SlidingExpiration = true;
    }
); 

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseMigrationsEndPoint();
} else {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();


