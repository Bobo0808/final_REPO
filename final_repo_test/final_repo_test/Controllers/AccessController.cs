using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ClassLibrary.ViewModels.Login;
using Microsoft.AspNetCore.Authorization;
using ClassLibrary.Models;
using NETCore.Encrypt.Extensions;
using ClassLibrary;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace final_repo_test.Controllers
{
    //[Authorize]
    public class AccessController : Controller
    {
        private readonly ChickenDbContext _context;

        public AccessController(ChickenDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel LoginVM)
        {
            var user = await _context.Employees.SingleOrDefaultAsync(u => u.E_Email == LoginVM.E_Email && u.E_Pwd ==LoginVM.E_Pwd);

            //要加密放在if裡面
            if (user != null )
            {
                List<Claim> claims = new List<Claim>() {
                new Claim(ClaimTypes.NameIdentifier, LoginVM.E_Email),
                    new Claim("OtherProperties", "Example Role")
            };
                ClaimsIdentity Claimsidentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = LoginVM.KeepLoggedIn
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(Claimsidentity), properties);
                return RedirectToAction("Index", "LoginStatus_Home", new { area = "LoginStatus" });
            }

            ViewData["ValodateMessage"] = "他媽的給我成功喔";
            return View();

        }
    }

}




//[HttpPost]
//public async Task<IActionResult> Login(LoginViewModel loginVM)
//{
//    var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == loginVM.E_Email);

//    if (user != null && VerifyPassword(user.PasswordHash, user.PasswordSalt, loginVM.E_Pwd))
//    {
//        List<Claim> claims = new List<Claim>
//        {
//            new Claim(ClaimTypes.NameIdentifier, loginVM.E_Email),
//            new Claim("OtherProperties", "Example Role")
//        };

//        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//        AuthenticationProperties properties = new AuthenticationProperties
//        {
//            AllowRefresh = true,
//            IsPersistent = loginVM.KeepLoggedIn
//        };

//        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
//        return RedirectToAction("Index", "Home");
//    }

//    ViewData["ValodateMessage"] = "Invalid email or password.";
//    return View();
//}
