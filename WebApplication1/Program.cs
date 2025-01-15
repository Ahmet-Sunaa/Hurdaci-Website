using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication1.DAL.Context;
using WebApplication1.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// HurdaciContext hizmetini ekleyin
builder.Services.AddDbContext<HurdaciContext>();

// Cookie Authentication ekleyin
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index";  // Yetkisiz eriþim durumunda yönlendirme
        options.LogoutPath = "/Layout/Index"; // Çýkýþ iþlemi
        options.AccessDeniedPath = "/Login/Index"; // Eriþim engellenmiþse yönlendirme
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Oturum süresi
        options.SlidingExpiration = true;
        options.Cookie.Expiration = null;
        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Sadece HTTPS ile çerez gönderilir
        options.Cookie.SameSite = SameSiteMode.Strict;
    });

var app = builder.Build();

// Middleware yapýlandýrmalarý
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Kimlik doðrulama ve yetkilendirme middleware'leri
app.UseAuthentication();
app.UseAuthorization();

// Varsayýlan admin kaydýný oluþtur
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<HurdaciContext>();
    PasswordHelper.SeedAdmin(context); // SeedAdmin çaðrýsý
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");  // Varsayýlan rota, Default/Index

app.Run();
