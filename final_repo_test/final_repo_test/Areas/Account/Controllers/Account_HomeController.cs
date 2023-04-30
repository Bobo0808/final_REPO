using final_repo_test.Data;
using final_repo_test.Models;
using final_repo_test.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace final_repo_test.Areas.Account.Controllers
{
    [Area("Account")]
    public class Account_HomeController : Controller
    {
        //下面三行要用DBcontext要創的
        private readonly ApplicationDbContext applicationDbContext;
        
        public Account_HomeController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        //這邊以上
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(AddVM addAccountRequest)
        {
            var account = new UserAccount()
            {
                A_Name = addAccountRequest.A_Name,
                UserName = addAccountRequest.UserName,
                UserPWD = addAccountRequest.UserPWD,
                A_Gender = addAccountRequest.A_Gender,
                Birthday = addAccountRequest.Birthday,
                A_level = addAccountRequest.A_level,
                A_Email = addAccountRequest.A_Email,
                A_Phone = addAccountRequest.A_Phone,
                A_add = addAccountRequest.A_add,
                A_RegisteredAt = addAccountRequest.A_RegisteredAt,
                A_NickName = addAccountRequest.A_NickName,
                A_Coin = addAccountRequest.A_Coin,
                P_id = addAccountRequest.P_id,
                
                
            };
            await applicationDbContext.Accounts.AddAsync(account);
            await applicationDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
            

        }
       
       
    }
}
