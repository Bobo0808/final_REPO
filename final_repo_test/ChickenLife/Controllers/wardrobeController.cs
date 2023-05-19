using ClassLibrary;
using ClassLibrary.ViewModels.WardrobeViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChickenLife.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class wardrobeController : Controller
    {
        private readonly ChickenDbContext _context;
        public wardrobeController(ChickenDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("details/{id}")]
        public async Task<ActionResult<WardrobeViewModel>> GetDetails(int? id)
        {
            //if (id != user.A_ID)
            //{
            //    return BadRequest("Invalid ID");
            //}

            var result = await _context.Accounts.Where(x => x.A_ID == id).Include(a => a.Orders).ThenInclude(o => o.OrderDetails).ThenInclude(od => od.Product).Select(x => new {
                userid = x.A_ID,
                orderid = x.Orders.Select(o => o.O_ID).ToList(),
                productid = x.Orders.Select(o => o.OrderDetails.Select(od => od.P_ID)).ToList(),
                productname = x.Orders.Select(o => o.OrderDetails.Select(od => od.Product).Select(p => p.P_Name)).ToList(),
                productimage = x.Orders.Select(o => o.OrderDetails.Select(od => od.Product).Select(p => p.P_Image)).ToList()
            }).ToListAsync();
            WardrobeViewModel wardrobetemp = new WardrobeViewModel()
            {
                UserID = result.First().userid,
                OrderID = result.First().orderid,
                ProductID = result.First().productid,
                ProductName = result.First().productname,
                ProductImage = result.First().productimage,

            };
            if (wardrobetemp == null)
            {
                return NotFound();
            }

            return Ok(wardrobetemp);
        }
    }
}
