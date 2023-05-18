using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary;
using ChickenLife.Models.OrderProduct;

namespace webAPIforTest.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly ChickenDbContext _context;

        public OrderDetailsController(ChickenDbContext context)
        {
            _context = context;
        }

        // GET: api/OrderDetails
        [HttpGet]
        public IEnumerable<OrderDetailsDTO> GetCards()
        {
            //return await _context.Products.ToListAsync();
            return _context.OrderDetails.Select(orderdetail => new OrderDetailsDTO
            {
                Od_ID = orderdetail.Od_ID,
                O_ID = orderdetail.O_ID,
                P_ID = orderdetail.P_ID,
                Od_UnitPrice = Convert.ToInt32(orderdetail.Od_UnitPrice),
                Od_Sum = Convert.ToInt32(orderdetail.Od_Sum),
                Od_Quantity = orderdetail.Od_Quantity,

            });
        }

        // GET: api/OrderDetails/5
        [HttpGet("{id}")]
        public async Task<OrderDetailsDTO> GetOrderDetails(int id)
        {
            var cards = await _context.OrderDetails.FindAsync(id);

            return new OrderDetailsDTO
            {
                Od_ID = cards.Od_ID,
                O_ID = cards.O_ID,
                P_ID = cards.P_ID,
                Od_UnitPrice = Convert.ToInt32(cards.Od_UnitPrice),
                Od_Sum = Convert.ToInt32(cards.Od_Sum),
                Od_Quantity = cards.Od_Quantity,
            };
        }
        ////// 篩選
        ////// POST: api/Cards (會發現動詞與下面的POST相同而衝突)
        ////// 需增加參數POST:改為api/Employees/Filter 而url不同區別
        [HttpPost("Filter")]
        public async Task<IEnumerable<OrderDetailsDTO>> FilterCard([FromBody] OrderDetailsDTO odDTO)
        {
            // return null;
            return _context.OrderDetails
                .Where(card => card.Od_ID == odDTO.Od_ID ||
                              card.O_ID==odDTO.O_ID ||
                              card.P_ID==odDTO.P_ID)
                .Select(card => new OrderDetailsDTO
                {
                    Od_ID = card.Od_ID,
                    O_ID = card.O_ID,
                    P_ID = card.P_ID,
                    Od_UnitPrice = card.Od_UnitPrice,
                    Od_Sum = card.Od_Sum,
                    Od_Quantity = card.Od_Quantity,
                });
        }


        // PUT: api/OrderDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderDetails(int id, OrderDetailsDTO orderDetails)
        {
            if (id != orderDetails.Od_ID)
            {
                return BadRequest();
            }

            _context.Entry(orderDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostOrderDetails(OrderDetailsDTO orderDetails)
        {
          if (_context.OrderDetails == null)
          {
                //return Problem("Entity set 'ChickenLifeContext.OrderDetails'  is null.");
                return "無訂單詳細記錄";
          }
            OrderDetail od = new OrderDetail
            {
                //Od_ID = od.Od_ID,
                O_ID = orderDetails.O_ID,
                P_ID = orderDetails.P_ID,
                Od_UnitPrice = orderDetails.Od_UnitPrice,
                Od_Sum = orderDetails.Od_Sum,
                Od_Quantity = orderDetails.Od_Quantity,
            };
            _context.OrderDetails.Add(od);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetOrderDetails", new { id = orderDetails.Od_ID }, orderDetails);
            return "新增紀錄成功";
        }


        private bool OrderDetailsExists(int id)
        {
            return (_context.OrderDetails?.Any(e => e.Od_ID == id)).GetValueOrDefault();
        }
    }
}
