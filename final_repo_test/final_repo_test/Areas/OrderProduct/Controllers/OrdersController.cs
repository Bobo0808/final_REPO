using final_repo_test.Areas.OrderProduct.ViewModels;
using final_repo_test.Data;
using final_repo_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net;


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
                var orderstatus = order.O_Cancle == true ? "訂單取消" : "訂單完成";
                var orderViewModel = new ViewOrder
                {
                    O_ID = order.O_ID,
                    O_TotalPrice = order.O_TotalPrice,
                    O_Date = order.O_Date,
                    O_Satus = orderstatus,
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
            //    var order = await _context.Orders.FindAsync(id);
            //    if (order == null)
            //    {
            //        return NotFound();
            //    }
            //    var orderDetails = await _context.OrderDetails
            //.Where(od => od.O_ID == id)
            //.ToListAsync();

            //    ViewBag.CustomerIdList = new SelectList(orderDetails, "Od_ID", "Product_Name");

            //var orderdetailList = _context.OrderDetails.Select(od => new {
            //    OrderId = od.Od_ID,

            //}).ToList();
            //ViewData["OAId"] = new SelectList(_context.Accounts, "AId", "AId");
            //ViewBag.CustomerIdList = new SelectList(orderdetailList, "OrderId");
            //if (id == null || _context.Orders == null)
            //{
            //    return NotFound();
            //}

            //var order = await _context.Orders
            //    .Include(o => o.A_ID)
            //    .FirstOrDefaultAsync(m => m.O_ID == id);
            //if (order == null)
            //{
            //    return NotFound();
            //}

            //return View(orderDetails);
            var resultViewModel = from od in _context.OrderDetails
                                  join o in _context.Orders
                                  on od.O_ID equals o.O_ID into dt2
                                  from o in dt2.DefaultIfEmpty()
                                  where o.O_ID == id
                                  select new OrderDetailViewModel { selectDetails = od, selectOrder = o };
            return View(resultViewModel);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            // 創建一個SelectList，包含客戶ID和名字的對應關係
            var customerList = _context.Accounts.Select(c => new {
                CustomerId = c.A_ID,
                CustomerUserName = c.A_Name
            }).ToList();
            ViewBag.CustomerIdList = new SelectList(customerList, "CustomerId", "CustomerUserName");

            //載入多個資料
            //var order = new Order();
            //var orderdetail = new OrderDetail();
            //var orderdetails = new List<OrderDetail>();
            // 塞入一個 OrderDetail
            //orderdetails.Add(orderdetail);

            //載入商品
            //var productList = _context.Products.ToList();
            //var viewModel = new Tuple<Order, List<OrderDetail>, List<Product>>(order, orderdetails, productList);

            //return View("~/Areas/OrderProduct/Views/Orders/Create.cshtml", viewModel);

            ViewOrder viewOrder = new ViewOrder();
            viewOrder.Order = new Order();
            viewOrder.OrderDetails = new List<OrderDetail>();
            viewOrder.Products = _context.Products.ToList();
            return View("~/Areas/OrderProduct/Views/Orders/Create.cshtml", viewOrder);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        //public async Task<IActionResult> Create([Bind("A_ID,O_Date,O_TotalPrice,O_Cancle")] Order order)
        public async Task<IActionResult> Create([Bind("O_ID,A_ID,O_Date,O_TotalPrice,O_Cancle")] Order order, List<OrderDetail> orderDetails)
        {

            if (ModelState.IsValid)
            {

                _context.Add(order);
                await _context.SaveChangesAsync();

                var NewOrderDetail = new OrderDetail();
                foreach (var item in orderDetails)
                {
                    item.O_ID = order.O_ID;
                    _context.Add(item);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CustomerIdList = new SelectList(_context.Accounts, "A_ID", "A_Name", order.A_ID);

            //if (ModelState.IsValid)
            //{
            //    _context.Add(order);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewBag.order=order;
            return View("~/Areas/OrderProduct/Views/Orders/index.cshtml", order);
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
            return View("~/Areas/OrderProduct/Views/Orders/Edit.cshtml", order);
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

        [HttpPost]
        public ActionResult DeleteOrderDetail(int orderDetailId)
        {
            try
            {
                // Retrieve the order detail object based on the given orderDetailId parameter
                var orderDetail = _context.OrderDetails.Find(orderDetailId);

                if (orderDetail != null)
                {
                    _context.OrderDetails.Remove(orderDetail);
                    _context.SaveChanges();


                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        //訂單
        public IActionResult GetProductPrice(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.P_ID == productId);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }
            return Json(product.P_Price);
        }
    }
}
