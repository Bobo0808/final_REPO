using final_repo_test.Data;
using final_repo_test.Models;
using final_repo_test.ViewModels.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Login.Controllers
{
    public class Login_HomeController : Controller
    {
        private readonly UserManager<UserAccount> _userManager;
        private readonly SignInManager<UserAccount> _signInManager;
        private readonly ApplicationDbContext _context;

        //引入一個構造函數並為所有這些進行DI注入
        public Login_HomeController(UserManager<UserAccount> userManager, SignInManager<UserAccount>signInManager, ApplicationDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            
        }



        

        //[Area("Login")]
        public IActionResult Index()
        {
            //不小心按到重載不用重打
            //var response = new UserAccount();
            return View(/*response*/);
        }
        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel LoginViewModel)
        //{
        //    if(!ModelState.IsValid) return View(LoginViewModel);
        //    var user = await _userManager.FindByEmailAsync(LoginViewModel.Email);
            
            
        //    if (user != null) 
        //    {
        //        User 確定了 檢查密碼
        //        var passwordCheck = await _userManager.CheckPasswordAsync(user, LoginViewModel.PWD);
        //        密碼正確 登入
        //        if (passwordCheck)
        //        {
        //            var result = await _signInManager.PasswordSignInAsync(user,LoginViewModel.PWD, false, false);
                    
                    
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
                    
        //        }
        //        密碼錯誤
        //        TempData["Error"] = "錯誤請再輸入一次";
        //        return View(LoginViewModel);
        //    }
        //    User Not Found
        //    TempData["Error"] = "錯誤請在輸入一次";
        //    return View(LoginViewModel);
        //}
    }
}
