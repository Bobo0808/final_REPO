using ClassLibrary;
using ClassLibrary.Models;
using ClassLibrary.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace final_repo_test.Areas.Account.Controllers
{
    [Area("Account")]
    public class Account_HomeController : Controller
    {
        //下面三行要用DBcontext要創的
        private readonly ChickenDbContext applicationDbContext;

        public Account_HomeController(ChickenDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        //這邊以上
        [HttpGet]
        
        public async Task<IActionResult> Index()
        {
            var accounts = await applicationDbContext.Accounts.ToListAsync();
            return View(accounts);
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
        [HttpGet]
        public async Task<IActionResult> Edit(int? A_Id)
        {
            //if (A_Id == null)
            //{
            //    return RedirectToAction("Add");
            //}
            var account = await applicationDbContext.Accounts.FirstOrDefaultAsync(x => x.A_ID == A_Id);
            if (account != null)
            {
                var viewModel = new Edit()
                {
                    A_ID = account.A_ID,
                    A_Name = account.A_Name,
                    UserName = account.UserName,
                    UserPWD = account.UserPWD,
                    A_Gender = account.A_Gender,
                    Birthday = account.Birthday,
                    A_level = account.A_level,
                    A_Email = account.A_Email,
                    A_Phone = account.A_Phone,
                    A_add = account.A_add,
                    A_RegisteredAt = account.A_RegisteredAt,
                    A_NickName = account.A_NickName,
                    A_Coin = account.A_Coin,
                    P_id = account.P_id,
                };
                return await Task.Run(() => View("Edit", viewModel));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Edit edit)
        {
            var account = await applicationDbContext.Accounts.FindAsync(edit.A_ID);
            if (account != null)
            {
                account.A_ID = edit.A_ID;
                account.A_Name = edit.A_Name;
                account.UserName = edit.UserName;
                account.UserPWD = edit.UserPWD;
                //account.PasswordHash = edit.UserPWD;
                account.A_Gender = edit.A_Gender;
                account.Birthday = edit.Birthday;
                account.A_level = edit.A_level;
                account.A_Email = edit.A_Email;
                account.A_Phone = edit.A_Phone;
                account.A_add = edit.A_add;
                account.A_RegisteredAt = edit.A_RegisteredAt;
                account.A_NickName = edit.A_NickName;
                account.A_Coin = edit.A_Coin;
                account.P_id = edit.P_id;

                await applicationDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Edit edit)
        {
            var account  = await applicationDbContext.Accounts.FindAsync(edit.A_ID);
            if (account != null) 
            {
                applicationDbContext.Accounts.Remove(account);
                await applicationDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
