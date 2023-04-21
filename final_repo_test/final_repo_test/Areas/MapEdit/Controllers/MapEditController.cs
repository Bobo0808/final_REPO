using final_repo_test.Data;
using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.MapEdit.Controllers
{
    [Area(areaName: "MapEdit")]
    public class MapEditController : Controller
    {
        

        public readonly ApplicationDbContext _context;
        public MapEditController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
