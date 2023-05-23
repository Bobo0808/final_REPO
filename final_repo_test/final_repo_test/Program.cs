using final_repo_test.Data;
using final_repo_test.Interfaces;
using final_repo_test.Repositroy;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication.Cookies;
using ClassLibrary;
using Microsoft.Extensions.Options;
using final_repo_test.Helpers;
using final_repo_test.Services;


//Debugger.Launch();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//使用Cookie來做身分驗證服務CookieAuthenticationDefaults是一個預設值，代表使用Cookie方案進行身分驗證。
//AddCookie方法來設定驗證選項LoginPath 當使用者需要進行身分驗證會導向的Url路徑
//ExpireTimeSpan使用者身分驗證的有效時間20min
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option => {
    option.LoginPath = "/Access/Login";
    option.LogoutPath = "/Access/Login";
    //option.AccessDeniedPath = "/Access/Login";
    option.Cookie.HttpOnly = true;
    option.SlidingExpiration = true;
    option.ExpireTimeSpan = TimeSpan.FromMinutes(1);
});
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDebugLogRepository, DebugLogRepository>();
builder.Services.AddScoped<ILoginStatusRepository, LoginStatusRepository>();
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//});
builder.Services.AddDbContext<ChickenDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),x=>x.MigrationsAssembly("final_repo_test"));
});


// 添加 Cloudinary 相關的服務
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));

var app = builder.Build();
if (args.Length == 1 && args[0].ToLower() == "seeddata")
{
    Seeding.SeedData(app);
}

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

app.UseCookiePolicy();
//確認使用者
app.UseAuthentication();
//授權
app.UseAuthorization();




app.MapControllerRoute(
    name: "areaRoute",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Access}/{action=Login}/{id?}");



app.Run();
