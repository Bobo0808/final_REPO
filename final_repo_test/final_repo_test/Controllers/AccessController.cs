﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using final_repo_test.Models;
using final_repo_test.ViewModels.Login;

namespace final_repo_test.Controllers
{
    public class AccessController : Controller
    {
        
        public IActionResult Login()
        {
            //ClaimsPrincipal claimUser = HttpContext.User;
            //if (claimUser.Identity.IsAuthenticated)
            //    return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (loginViewModel.E_Email=="user@gmail.com" && loginViewModel.E_Pwd =="1234") {
            List<Claim>claims = new List<Claim>() { 
            new Claim(ClaimTypes.NameIdentifier,loginViewModel.E_Email),new Claim("OtherProperties","Example Role")};
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties() {

                    AllowRefresh = false,
                    IsPersistent = loginViewModel.KeepLoggedIn
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),properties);
                return RedirectToAction("Index", "Account_Home", new { area = "Account" });
            }
            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}