using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.DebugLog.Controllers
{
    [Area("DebugLog")]
    public class DebugLog_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
