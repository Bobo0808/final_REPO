using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.LoginStatus.Controllers
{
    [Area("LoginStatus")]


    public class LoginStatus_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
