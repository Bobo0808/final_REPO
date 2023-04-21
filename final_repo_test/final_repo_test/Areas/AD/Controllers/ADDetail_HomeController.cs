using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.AD.Controllers
{
	public class ADDetail_HomeController : Controller
	{
		[Area(areaName: "AD")]
		public IActionResult Index()
		{
			return View();
		}
	}
}