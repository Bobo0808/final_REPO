﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ClassLibrary.ViewModels.Login;
using Microsoft.AspNetCore.Authorization;
using ClassLibrary.Models;
using NETCore.Encrypt.Extensions;
using ClassLibrary;
using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Controllers
{
    [Authorize]
    public class AccessController : Controller
    { 
        private readonly ChickenDbContext _context;
        private readonly IConfiguration _configuration;
        [AllowAnonymous]
        public IActionResult Login()
        {
            //ClaimsPrincipal claimUser = HttpContext.User;
            //if (claimUser.Identity.IsAuthenticated)
            //    return RedirectToAction("Index", "Account_Home", new { area = "Account" });
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid) {

                string hashedPassword = DoMD5HashedString(loginViewModel.E_Pwd);

                Employee user = _context.Employees.SingleOrDefault(e => e.E_Email==loginViewModel.E_UserName && e.E_Pwd == hashedPassword);

                if (user != null) { 
                    if(user.Locked)
                    {
                        ModelState.AddModelError(nameof(loginViewModel), "User is locked.");
                        return View(loginViewModel);
                    }
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.E_ID.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.E_Name ?? string.Empty));
                    claims.Add(new Claim(ClaimTypes.Role, user.Role));
                    claims.Add(new Claim("Username", user.E_UserName));

                    ClaimsIdentity identity = new ClaimsIdentity(claims,
                   CookieAuthenticationDefaults.AuthenticationScheme);

                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                   await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return RedirectToAction("Index", "Account_Home", new { area = "Account" });
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect.");
                }



                //AuthenticationProperties properties = new AuthenticationProperties() {

                //    //是否允許刷新Cookie
                //    AllowRefresh = true,
                //    IsPersistent = loginViewModel.KeepLoggedIn
                //};
                //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                //    new ClaimsPrincipal(claimsIdentity),properties);

            }
            //ViewData["ValidateMessage"] = "user not found";
            return View(loginViewModel);
        }
        //下載Encrypt
        private string DoMD5HashedString(string s)
        {
            string md5Salt = _configuration.GetValue<string>("AppSettings:MD5Salt");
            string salted = s + md5Salt;
            string hashed = salted.MD5();
            return hashed;
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterViewModel Rmodel)
        {
            if (ModelState.IsValid)
            {
                if (_context.Employees.Any(x => x.E_UserName.ToLower() == Rmodel.E_UserName.ToLower()))
                {
                    ModelState.AddModelError(nameof(Rmodel.E_UserName), "Username is already exists.");
                    View(Rmodel);
                }

                string hashedPassword = DoMD5HashedString(Rmodel.E_Pwd);

                Employee user = new()
                {
                    E_UserName = Rmodel.E_UserName,
                    E_Pwd = hashedPassword
                };

                _context.Employees.Add(user);
                int affectedRowCount = _context.SaveChanges();

                if (affectedRowCount == 0)
                {
                    ModelState.AddModelError("", "User can not be added.");
                }
                else
                {
                    return RedirectToAction(nameof(Login));
                }
            }

            return View(Rmodel);
        }
        //public IActionResult Profile()
        //{
        //    ProfileInfoLoader();

        //    return View();
        //}

        //private void ProfileInfoLoader()
        //{
        //    int userid = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //    Employee user = _context.Employees.SingleOrDefault(x =>x.E_ID  == Convert.ToInt32(userid));

        //    ViewData["FullName"] = user.E_Name;
        //}

        //[HttpPost]
        //public IActionResult ProfileChangeFullName([Required][StringLength(50)] string? fullname)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Guid userid = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //        Employee user = _context.Employees.SingleOrDefault(x => x.E_ID == userid);

        //        user.E_Name = fullname;
        //        _context.SaveChanges();

        //        return RedirectToAction(nameof(Profile));
        //    }

        //    ProfileInfoLoader();
        //    return View("Profile");
        //}

        //[HttpPost]
        //public IActionResult ProfileChangePassword([Required][MinLength(6)][MaxLength(16)] string? password)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Guid userid = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //        Employee user = _context.Employees.SingleOrDefault(x => x.E_ID == userid);

        //        string hashedPassword = DoMD5HashedString(password);

        //        user.Password = hashedPassword;
        //        _context.SaveChanges();

        //        ViewData["result"] = "PasswordChanged";
        //    }

        //    ProfileInfoLoader();
        //    return View("Profile");
        //}

    }
}
 