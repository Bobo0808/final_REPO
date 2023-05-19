using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.ViewModels.WardrobeViewModel;
using ClassLibrary.Models;
using final_repo_test.Models;

namespace final_repo_test.Areas.wardrobe.Controllers
{
    [Area("wardrobe")]
    public class wardrobeController : Controller
    {
        private readonly ChickenDbContext _context;
        public wardrobeController(ChickenDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet("{id}")]
        //public async Task<EmployeeDTO> GetEmployees(int id)
        //{
        //    var employees = await _context.Employees.FindAsync(id);

        //    return new EmployeeDTO
        //    {
        //        EmployeeId = employees.EmployeeId,
        //        FirstName = employees.FirstName,
        //        LastName = employees.LastName,
        //        Title = employees.Title
        //    };
        //}


        //[HttpGet]
        //public async Task<IEnumerable<WardrobeViewModel>> Detail()//改成GetEmployees
        //{
        //    return _context.OrderDetails
        //                .Include(a => a.Order)
        //                .Include(a => a.Product)
        //                .Select(a => new WardrobeViewModel
        //                {
        //                    UserID = a.Order.A_ID,
        //                    OrderID = a.O_ID,
        //                    ProductID = a.P_ID,
        //                    ProductName = a.Product.P_Name,
        //                    ProductImage = a.Product.P_Image
        //                });
        //}

        //[HttpGet("{id}")]
        //public async Task<IEnumerable<WardrobeViewModel>> HI(int id)
        //{

        //    var result = await _context.Accounts.Where(x => x.A_ID == id).Include(a => a.Orders).ThenInclude(o => o.OrderDetails).ThenInclude(od => od.Product).ToListAsync();
        //    List<WardrobeViewModel> wardrobetemp = new List<WardrobeViewModel>();

        //    //for (int i = 0; i < result.Count; i++)
        //    //{
        //    //    wardrobetemp.Add(new WardrobeViewModel()
        //    //    {
        //    //        UserID = result[i].A_ID,
        //    //        ProductID = result[i].Product.P_ID,
        //    //        ProductName = result[i].Product.P_Name,
        //    //        ProductImage = result[i].Product.P_Image
        //    //    });
        //    //}

        //    //var result = await _context.Accounts
        //    //    .Include(a => a.Orders)
        //    //        .ThenInclude(o => o.OrderDetails)
        //    //            .ThenInclude(od => od.Product)
        //    //    .SelectMany(a => a.Orders.SelectMany(o => o.OrderDetails.Select(od => new WardrobeViewModel
        //    //    {
        //    //        UserID = a.A_ID,
        //    //        OrderID = o.O_ID,
        //    //        ProductID = od.Product.P_ID,
        //    //        ProductName = od.Product.P_Name,
        //    //        ProductImage = od.Product.P_Image

        //    //    })))
        //    //    .ToListAsync();

        //    return wardrobetemp;
        //}


        //public async Task<IActionResult> Detail()//改成GetEmployees
        //{

        //    var ward = await _context.OrderDetails
        //                .Include(a => a.Order)
        //                .Include(a => a.Product)
        //                .Select(a => new WardrobeViewModel
        //{
        //    UserID = a.Order.A_ID,
        //    OrderID = a.O_ID,
        //    ProductID = a.P_ID,
        //    ProductName = a.Product.P_Name,
        //    ProductImage = a.Product.P_Image
        //})
        //.ToListAsync();

        //    return View(ward);
        //}

    }
}
