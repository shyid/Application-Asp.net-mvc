using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using test3.Areas.Identity.Data;
using NetCoreAdmin;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("test3IdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'test3IdentityDbContextConnection' not found.");

builder.Services.AddDbContext<test3IdentityDbContext>(options => options.UseSqlServer(connectionString));

// builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
//     .AddEntityFrameworkStores<test3IdentityDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<test3IdentityDbContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(
options => {
    options.Stores.MaxLengthForKeys = 128;
})
.AddEntityFrameworkStores<test3IdentityDbContext>()
.AddRoles<IdentityRole>()
.AddDefaultUI()
.AddDefaultTokenProviders();

// builder.Services.AddCoreAdmin(); //in /AdminCore add to url go to adminstore

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

//Seed database
AppDbInitializer.Seed(app);
                        
app.Run();
