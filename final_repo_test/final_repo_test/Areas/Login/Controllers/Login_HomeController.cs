using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Login.Controllers
{
    public class Login_HomeController : Controller
    {
        [Area("Login")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
