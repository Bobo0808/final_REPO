using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.Employee.Controllers
{
    public class Employee_HomeController : Controller
    {
        [Area("Employee")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
