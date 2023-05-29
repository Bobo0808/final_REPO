using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChickenLife.Models.OrderProduct;
using ClassLibrary;
using ChickenLife.Models.OrderProduct.DTO;
using ClassLibrary.Models;

namespace webAPIforTest.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ChickenDbContext _context;

        public OrderController(ChickenDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public IEnumerable<OrderDTO> GetCards()
        {
            //return await _context.Products.ToListAsync();
            return _context.Orders.Where(order => order.O_Cancle == false).Select(order => new OrderDTO
            {
                O_ID = order.O_ID,
                A_ID = order.A_ID,
                O_Date = order.O_Date,
                O_TotalPrice = Convert.ToInt32(order.O_TotalPrice),
                O_Cancle = order.O_Cancle,

            });
        }

        //// GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<OrderDTO> GetOrders(int id)
        {
            //if (_context.Orders == null)
            //{
            //    return NotFound();
            //}
            var orders = await _context.Orders.FindAsync(id);

            //if (orders == null)
            //{
            //    return NotFound();
            //}

            //return orders;
            return new OrderDTO
            {
                O_ID = orders.O_ID,
                A_ID = orders.A_ID,
                O_Date = orders.O_Date,
                O_TotalPrice = Convert.ToInt32(orders.O_TotalPrice),
                O_Cancle = orders.O_Cancle,
            };
        }

        // 篩選
        // POST: api/Orders (會發現動詞與下面的POST相同而衝突)
        // 需增加參數POST:改為api/Orders/Filter 而url不同區別
        [HttpPost("Filter")]
        public async Task<IEnumerable<OrderDTO>> FilterOrder([FromBody] OrderDTO orderDTO)
        {
            // return null;
            return _context.Orders
                .Where(o => o.O_ID == orderDTO.O_ID ||
                              o.A_ID == orderDTO.A_ID ||
                              o.O_Cancle == orderDTO.O_Cancle)
                .Select(o => new OrderDTO
                {
                    O_ID = o.O_ID,
                    A_ID = o.A_ID,
                    O_Date = o.O_Date,
                    O_TotalPrice = Convert.ToInt32(o.O_TotalPrice),
                    O_Cancle = o.O_Cancle,
                });
        }

        [HttpPost("FilterAccount")]
        public async Task<IEnumerable<OrderDTO>> FilterAccountOrder([FromBody] OrderDTO orderDTO)
        {
            return _context.Orders
                .Where(o => (o.A_ID == orderDTO.A_ID) &&
                            (o.O_Date.Month == orderDTO.O_Date.Month ||
                            o.O_Cancle == false))
                .Select(o => new OrderDTO
                {
                    O_ID = o.O_ID,
                    A_ID = o.A_ID,
                    O_Date = o.O_Date,
                    O_TotalPrice = Convert.ToInt32(o.O_TotalPrice),
                    O_Cancle = o.O_Cancle,
                    ProductName = _context.OrderDetails
                                .Where(d => d.O_ID == o.O_ID)
                                .Join(_context.Products,
                                    d => d.P_ID,
                                    p => p.P_ID,
                                    (d, p) => p.P_Name)
                                .FirstOrDefault()
                });
        }

        [HttpPost("FilterAPID")]
        public async Task<bool> FilterAccountProductOrder([FromBody] CheckDTO chk)
        {
            bool hasProductOrder = await _context.Orders
                .AnyAsync(o => o.A_ID == chk.A_ID && o.O_Cancle == false &&
                               o.OrderDetails.Any(d => d.P_ID == chk.P_ID));

            return hasProductOrder;
        }


        // 顯示訂單
        // POST: api/Orders (會發現動詞與下面的POST相同而衝突)
        // 需增加參數POST:改為api/Orders/Show 而url不同區別
        [HttpPost("Show")]
        public async Task<IEnumerable<OrderDTO>> ShowAccountOrder([FromBody] OrderDTO orderDTO)
        {
            // return null;
            //return _context.Orders
            //    .Where(o => o.A_ID == orderDTO.A_ID)
            //    .Select(o => new OrderDTO
            //    {
            //        O_ID = o.O_ID,
            //        A_ID = o.A_ID,
            //        O_Date = o.O_Date,
            //        O_TotalPrice = Convert.ToInt32(o.O_TotalPrice),
            //        O_Cancle = o.O_Cancle,
            //    });
            return _context.Orders
                .Where(o => o.A_ID == orderDTO.A_ID)
                .Select(o => new OrderDTO
                {
                    O_ID = o.O_ID,
                    A_ID = o.A_ID,
                    O_Date = o.O_Date,
                    O_TotalPrice = Convert.ToInt32(o.O_TotalPrice),
                    O_Cancle = o.O_Cancle,
                    ProductName = _context.OrderDetails
                                .Where(d => d.O_ID == o.O_ID)
                                .Join(_context.Products,
                                    d => d.P_ID,
                                    p => p.P_ID,
                                    (d, p) => p.P_Name)
                                .FirstOrDefault()
                });
        }

        //只修改訂單取消
        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("Cancel/{id}")]
        public async Task<string> PutOrders(int id, OrderDTO orders)
        {
            if (id != orders.O_ID)
            {
                //return BadRequest();
                return "讀取紀錄發生錯誤!";
            }
            Order o = await _context.Orders.FindAsync(id);
            o.O_Cancle = orders.O_Cancle;

            _context.Entry(o).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(id))
                {
                    //return NotFound();
                    return "修改訂單發生錯誤!";
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();
            return "修改訂單成功!";
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostOrders(OrderDTO orders)
        {
            if (_context.Orders == null)
            {
                //return Problem("Entity set 'ChickenLifeContext.Orders'  is null.");
                return "尚無訂單紀錄";
            }

            Order o = new Order
            {
                O_ID = orders.O_ID,
                A_ID = orders.A_ID,
                O_Date = orders.O_Date,
                O_TotalPrice = Convert.ToInt32(orders.O_TotalPrice),
                O_Cancle = false,
            };

            _context.Orders.Add(o);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetOrders", new { id = orders.O_ID }, orders);

            return "新增訂單成功";
        }


        private bool OrdersExists(int id)
        {
            return (_context.Orders?.Any(e => e.O_ID == id)).GetValueOrDefault();
        }


        // GET: api/Orders
        [HttpGet("GET/{id}")]
        public int GetOrderID(int id)
        {
            //return await _context.Products.ToListAsync();
            var lastOrder = _context.Orders.Where(order => order.A_ID == id).OrderByDescending(order => order.O_ID).FirstOrDefault();

            if (lastOrder != null)
            {
                return lastOrder.O_ID;
            }

            // 如果找不到符合條件的訂單，可以回傳一個適當的預設值，例如 -1 表示找不到
            return -1;
        }

    }
}
