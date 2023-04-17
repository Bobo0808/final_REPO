using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Report.Controllers
{
    [Area(areaName:"Report") ]
    public class Report_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("../Views/Report_Home/index.cshtml");
        }
    }
}
