using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Report.Controllers
{
    public class Report_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("../Views/Report_Home/index.cshtml");
        }
    }
}
