using final_repo_test.Areas.OrderProduct.ViewModels;
using final_repo_test.Data;
using final_repo_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Areas.OrderProduct.Controllers
{
    [Area(areaName: "OrderProduct")]
    public class OrdersController : Controller
    {
        public readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();
            //var finalContext = _context.Orders.Include(o => o.);

            var orderViewModels = new List<ViewOrder>();
            foreach (var order in orders)
            {
                var account = _context.Accounts.FirstOrDefault(a => a.A_ID == order.A_ID);
                var accountName = account != null ? account.UserName : "";

                var orderViewModel = new ViewOrder
                {
                    O_ID = order.O_ID,
                    O_TotalPrice = order.O_TotalPrice,
                    O_Date = order.O_Date,
                    O_Cancle = order.O_Cancle,
                    UserName = accountName
                };
                orderViewModels.Add(orderViewModel);
            }
            ViewBag.OrderViewModels = orderViewModels;
            //return View(orderViewModels);
            return View("~/Areas/OrderProduct/Views/Orders/index.cshtml");
            //return View();
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var orderdetailList = _context.OrderDetails.Select(od => new {
                OrderId = od.Od_ID,

            }).ToList();
            //ViewData["OAId"] = new SelectList(_context.Accounts, "AId", "AId");
            ViewBag.CustomerIdList = new SelectList(orderdetailList, "OrderId");
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.A_ID)
                .FirstOrDefaultAsync(m => m.O_ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View("~/Areas/OrderProduct/Views/Orders/Details.cshtml",order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            // 創建一個SelectList，包含客戶ID和名字的對應關係
            var customerList = _context.Accounts.Select(c => new {
                CustomerId = c.A_ID,
                CustomerUserName = c.A_Name
            }).ToList();
            //ViewData["OAId"] = new SelectList(_context.Accounts, "AId", "AId");
            ViewBag.CustomerIdList = new SelectList(customerList, "CustomerId", "CustomerUserName");
            return View("~/Areas/OrderProduct/Views/Orders/Create.cshtml");
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("A_ID,O_Date,O_TotalPrice,O_Cancle")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["OAId"] = new SelectList(_context.Accounts, "AId", "AId", order.OAId);
            ViewBag.order=order;
            return View("~/Areas/OrderProduct/Views/Orders/index.cshtml",order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_ID", order.A_ID);

            //return View(order);
            return View("~/Areas/OrderProduct/Views/Orders/Edit.cshtml",order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("O_Id,A_ID,O_Date,O_TotalPrice,O_Cancele")] Order order)
        {
            if (id != order.O_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.O_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_ID", order.A_ID);
            return View("~/Areas/OrderProduct/Views/Orders/index.cshtml", order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.A_ID)
                .FirstOrDefaultAsync(m => m.O_ID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Orders == null)
            {
                return Problem("Entity set 'FinalContext.Orders'  is null.");
            }
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return (_context.Orders?.Any(e => e.O_ID == id)).GetValueOrDefault();
        }



    }
}
