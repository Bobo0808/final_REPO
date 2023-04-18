using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Account.Controllers
{
    [Area("Account")]
    public class Account_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
