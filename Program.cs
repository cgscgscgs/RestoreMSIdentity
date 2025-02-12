
/*using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestoreMSIdentity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
//.AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

//builder.Services.AddControllersWithViews(options =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//        .RequireAuthenticatedUser()
//        .Build();
//    options.Filters.Add(new AuthorizeFilter(policy));
//});
//builder.Services.AddRazorPages()
//    .AddMicrosoftIdentityUI();


builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();
builder.Services.AddDbContext<RestoreMSIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestoreMSIdentityContext") ?? throw new InvalidOperationException("Connection string 'RestoreMSIdentityContext' not found.")));


//builder without az authentication 
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//---------------------------


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//added this
app.MapStaticAssets();

app.UseRouting();

//app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();

*/




// above was original cloned repo with FourthAttempt
// below is changes added by Celina to a downloaded repo.
// copy pasted here to keep track of changes. she messed up downloaded zip, 
// so had to copy paste the changes to the CLONED repo.
// repo cloned on 2/11/2022 7:20pm, and all changes made to downloaded zip were manually added here.



/*  date                   developer                    changes
 * 2/10/2025             Celina                   downloaded nuget package for OpenIDConnect
 * 2/11/2025             Celina                   downloaded nuget package for Web.UI
 * 2/11/2025             Celina                 added AddRazorRuntimeCompilation() to builder.Services.AddControllersWithViews
 * 
 * 
 */


using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestoreMSIdentity.Data;

var builder = WebApplication.CreateBuilder(args);


//Add services to the container.
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
.AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));

});
//.AddRazorRuntimeCompilation(); // celina added this 2/11 to allow landing page to show

builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI(); // uses web.ui using statement, package added 2/11



builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




//duplicate code, this below is og Celina's code
/*builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();
builder.Services.AddDbContext<RestoreMSIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestoreMSIdentityContext") ?? throw new InvalidOperationException("Connection string 'RestoreMSIdentityContext' not found.")));

*/


//builder without az authentication 
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//added this
app.MapStaticAssets();

app.UseRouting();

//app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();

