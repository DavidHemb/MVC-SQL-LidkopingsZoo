using LidkopingsZoo.Data;
using LidkopingsZoo.Services.Tours;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<TourServices>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using(var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "Guide", "Member" };
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}
using (var scope = app.Services.CreateScope())
{
    //ADMIN
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    string email = "Admin@mail.com";
    string password = "Admin1!";
    if (await userManager.FindByEmailAsync(email) == null)
    {
        var user = new IdentityUser();
        user.UserName = email;
        user.Email = email;
        user.EmailConfirmed = true;
        await userManager.CreateAsync (user, password);
        await userManager.AddToRoleAsync(user, "Admin");
    }
    //GUIDES
    userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    List<string> Emails = new List<string>();
    Emails.Add("Guido");
    Emails.Add("AceVentura");
    Emails.Add("CrocodileDundee");
    List<string> Passwords = new List<string>();
    Passwords.Add("Guide1!");
    Passwords.Add("Guide2!");
    Passwords.Add("Guide3!");
    int i = 0;
    foreach (string emails in Emails)
    { 
        if (await userManager.FindByEmailAsync(Emails[i]) == null)
        {
            var user = new IdentityUser();
            user.UserName = Emails[i];
            user.Email = Emails[i] + "@mail.com";
            user.EmailConfirmed = true;
            await userManager.CreateAsync(user, Passwords[i]);
            await userManager.AddToRoleAsync(user, "Guide");
            i++;
        }
        else if (await userManager.FindByEmailAsync(Emails[i]) != null)
        {
            break;
        }
    }
}
app.Run();
