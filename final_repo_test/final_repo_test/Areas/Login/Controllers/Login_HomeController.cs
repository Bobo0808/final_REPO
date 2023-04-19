using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Login.Controllers
{
    public class Login_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Areas/Login/Views/Login_Home/Index.cshtml");
        }
    }
}
