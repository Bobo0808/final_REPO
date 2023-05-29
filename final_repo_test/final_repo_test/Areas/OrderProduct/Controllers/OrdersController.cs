using ClassLibrary.ViewModels.OrderProduct;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net;
using ClassLibrary;

namespace final_repo_test.Areas.OrderProduct.Controllers
{
    [Area(areaName: "OrderProduct")]
    public class OrdersController : Controller
    {
        public readonly ChickenDbContext _context;
        public OrdersController(ChickenDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id = 1)
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
                    O_Cancle = order.O_Cancle,
                    UserName = accountName
                };
                orderViewModels.Add(orderViewModel);
            }
            ViewBag.OrderViewModels = orderViewModels;
            //return View(orderViewModels);
            //return View("~/Areas/OrderProduct/Views/Orders/index.cshtml");
            //return View();

            var applicationDbContext = _context.Orders.Include(c => c.Account).Include(c => c.OrderDetails);
            //ViewBag.Status = sbPageList.ToString();

            // PageSize變數: 每頁幾筆
            int PageSize = 10;

            // RecordCount變數，符合條件的總共有幾筆記錄？
            int RecordCount = _context.Orders.Count();

            // NowPageCount 目前正在觀賞這一頁紀錄，目前正在?
            int NowPageCount = 0;
            if (id > 0)
            {
                NowPageCount = (int)((id - 1) * PageSize);
            }
            // orderby順排序 descending反排序
            // skip從哪裡開始(忽略前面幾筆紀錄)
            var ListAll = (from Order in _context.Orders
                           orderby Order.O_ID
                           select Order)
                         .Skip(NowPageCount)
                         .Take(PageSize);
            //*** 查詢結果 ListAll 是一個 IQueryable ***
            ////if (ListAll == null) // 查無資料時，無法正確運作。因為 IQueryable<T>會傳回一個「空集合」而不是「空（null）。所以這段if辨別不了」
            if (ListAll.Any() == false)  // 可運作
            ////if (ListAll.GetEnumerator().MoveNext() == false)   // 可運作
            {   // 找不到任何記錄。 .NET Core改用 NotFound();
                return NotFound();
            }
            else
            {
                #region
                // Pages變數，「總共需要幾頁」才能把所有紀錄展示完畢？
                int Pages;
                if ((RecordCount % PageSize) > 0)
                {   //-- %，除法，傳回餘數
                    Pages = ((RecordCount / PageSize) + 1);   //-- ( / )除法。傳回整數。  如果無法整除，有餘數，則需要多出一頁來呈現。 
                }
                else
                {
                    Pages = (RecordCount / PageSize);   //-- ( /)除法。傳回整數
                }



                System.Text.StringBuilder sbPageList = new System.Text.StringBuilder();
                if (Pages > 0)
                {   //有傳來「頁數(p)」，而且頁數正確（大於零），出現<上一頁>、<下一頁>這些功能
                    sbPageList.Append("<div align='center'>");

                    //** 可以把檔名刪除，只留下 ?P=  即可！一樣會運作，但IE 11會出現 JavaScript錯誤。**
                    //** 抓到目前網頁的「檔名」。 System.IO.Path.GetFileName(Request.PhysicalPath) **
                    if (id > 1)
                    {   //======== 分頁功能（上一頁 / 下一頁）=========start===                
                        sbPageList.Append("<a href='?id=" + (id - 1) + "'>[<<<上一頁]</a>");
                    }
                    sbPageList.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b><a href='https://backsite.azurewebsites.net/OrderProduct/Orders'>[首頁]</a></b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                    if (id < Pages)
                    {
                        sbPageList.Append("<a href='?id=" + (id + 1) + "'>[下一頁>>>]</a>");
                    }  //======== 分頁功能（上一頁 / 下一頁）=========end====


                    //==========================================================
                    //========= MIS2000 Lab.自製的「每十頁」一間隔，分頁功能=========start====
                    sbPageList.Append("<hr width='97%' size=1>");

                    int block_page = 0;
                    block_page = id / 10;   //--只取除法的整數成果（商），若有餘數也不去管它。

                    if (block_page > 0)
                    {
                        sbPageList.Append("<a href='?id=" + (((block_page - 1) * 10) + 9) + "'> [前十頁<<]  </a>&nbsp;&nbsp;");
                    }

                    for (int K = 0; K <= 10; K++)
                    {
                        if ((block_page * 10 + K) <= Pages)
                        {   //--- Pages 資料的總頁數。共需「幾頁」來呈現所有資料？
                            if (((block_page * 10) + K) == id)
                            {   //--- id 就是「目前在第幾頁」
                                sbPageList.Append("[<b>" + id + "</b>]" + "&nbsp;&nbsp;&nbsp;");
                            }
                            else
                            {
                                if (((block_page * 10) + K) != 0)
                                {
                                    sbPageList.Append("<a href='?id=" + (block_page * 10 + K) + "'>" + (block_page * 10 + K) + "</a>");
                                    sbPageList.Append("&nbsp;&nbsp;&nbsp;");
                                }
                            }
                        }
                    }  //for迴圈 end

                    if ((block_page < (Pages / 10)) & (Pages >= (((block_page + 1) * 10) + 1)))
                    {
                        sbPageList.Append("&nbsp;&nbsp;<a href='?id=" + ((block_page + 1) * 10 + 1) + "'>  [>>後十頁]  </a>");
                    }
                    sbPageList.Append("</div>");
                }
                #endregion

                ViewBag.PageList = sbPageList.ToString();
                return View(ListAll.ToList());
            }
        }
        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            //var resultViewModel = from od in _context.OrderDetails
            //                      join o in _context.Orders
            //                      on od.O_ID equals o.O_ID into dt2
            //                      from o in dt2.DefaultIfEmpty()
            //                      where o.O_ID == id
            //                      select new OrderDetailViewModel { selectDetails = od, selectOrder = o };

            var resultViewModel = from od in _context.OrderDetails
                                  join o in _context.Orders
                                  on od.O_ID equals o.O_ID into dt2
                                  from o in dt2.DefaultIfEmpty()
                                  join p in _context.Products
                                  on od.P_ID equals p.P_ID into dt3
                                  from p in dt3.DefaultIfEmpty()
                                  where o.O_ID == id
                                  select new OrderDetailViewModel
                                  {
                                      selectDetails = od,
                                      selectOrder = o,
                                      ProductName = p != null ? p.P_Name : ""
                                  };
            return View(resultViewModel);
        }
        #region 新增(已廢除
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
        #endregion
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
        public async Task<IActionResult> Edit(int id, [Bind("O_ID,A_ID,O_Date,O_TotalPrice,O_Cancle")] Order order)
        {
            //if (id != order.O_ID)
            //{
            //    return NotFound();
            //}


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

            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_ID", order.A_ID);

            return RedirectToAction(nameof(Index));
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Account)
                .Include(o => o.OrderDetails)
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
