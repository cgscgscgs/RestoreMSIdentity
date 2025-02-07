//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.OpenIdConnect;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc.Authorization;
//using Microsoft.Identity.Web;
//using Microsoft.Identity.Web.UI;
using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Data;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

//SQL Server ConnectionAzure
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

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


//builder.Services.AddDbContext<AppDBContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//NEW Azure SQL Connection
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));




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

