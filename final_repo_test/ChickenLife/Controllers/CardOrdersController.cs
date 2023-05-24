using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary;
using ChickenLife.Models.OrderProduct;
using ClassLibrary.Models;
using ChickenLife.Models.OrderProduct.DTO;

namespace webAPIforTest.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class CardOrdersController : ControllerBase
    {
        private readonly ChickenDbContext _context;

        public CardOrdersController(ChickenDbContext context)
        {
            _context = context;
        }

        // GET: api/CardOrders
        [HttpGet]
        public IEnumerable<CardOrderDTO> GetCardOrders()
        {
            //return await _context.Products.ToListAsync();
            return _context.CardOrders.Select(cardorder => new CardOrderDTO
            {
                CO_ID = cardorder.CO_ID,
                A_ID = cardorder.A_ID,
                CA_ID = cardorder.CA_ID,
                CT_ID = cardorder.CT_ID,
                CO_Sum = cardorder.CO_Sum,
                CO_Date = cardorder.CO_Date,
                CO_Cancel = cardorder.CO_Cancel,
                CO_Quantity = cardorder.CO_Quantity,

            });
        }

        // GET: api/CardOrders/5
        [HttpGet("{id}")]
        public async Task<CardOrderDTO> GetCardOrders(int id)
        {
            //if (_context.CardOrders == null)
            //{
            //    return NotFound();
            //}
            var cardOrders = await _context.CardOrders.FindAsync(id);

            //if (cardOrders == null)
            //{
            //    return NotFound();
            //}

            return new CardOrderDTO
            {
                CO_ID = cardOrders.CO_ID,
                A_ID = cardOrders.A_ID,
                CA_ID = cardOrders.CA_ID,
                CT_ID = cardOrders.CT_ID,
                CO_Sum = cardOrders.CO_Sum,
                CO_Date = cardOrders.CO_Date,
                CO_Cancel = cardOrders.CO_Cancel,
                CO_Quantity = cardOrders.CO_Quantity,
            };
        }

        // 篩選
        // POST: api/CardOrders (會發現動詞與下面的POST相同而衝突)
        // 需增加參數POST:改為api/CardOrders/Filter 而url不同區別
        [HttpPost("Filter")]
        public async Task<IEnumerable<CardOrderDTO>> FilterCardOrder([FromBody] CardOrderDTO cardorderDTO)
        {
            // return null;
            return _context.CardOrders
                .Where(co => co.CO_ID == cardorderDTO.CO_ID ||
                              co.A_ID == cardorderDTO.A_ID ||
                              co.CA_ID == cardorderDTO.CA_ID ||
                              co.CT_ID == cardorderDTO.CT_ID)
                .Select(co => new CardOrderDTO
                {
                    CO_ID = co.CO_ID,
                    A_ID = co.A_ID,
                    CA_ID = co.CA_ID,
                    CT_ID = co.CT_ID,
                    CO_Sum = co.CO_Sum,
                    CO_Date = co.CO_Date,
                    CO_Cancel = co.CO_Cancel,
                    CO_Quantity = co.CO_Quantity,
                });
        }

        [HttpPost("FilterAccount")]
        public async Task<IEnumerable<CardOrderDTO>> FilterAccountCardOrder([FromBody] CardOrderDTO orderDTO)
        {
            return _context.CardOrders
                .Where(o => (o.A_ID == orderDTO.A_ID) &&
                            (o.CO_Date.Month == orderDTO.CO_Date.Month ||
                            o.CO_Cancel == false))
                .Join(_context.Cards,
                co => co.CA_ID,
                cp => cp.CA_ID,
                (co, cp) => new CardOrderDTO
                {
                    CO_ID = co.CO_ID,
                    A_ID = co.A_ID,
                    CA_ID = co.CA_ID,
                    CT_ID = co.CT_ID,
                    CO_Sum = co.CO_Sum,
                    CO_Date = co.CO_Date,
                    CO_Cancel = co.CO_Cancel,
                    CO_Quantity = co.CO_Quantity,
                    CA_Name = cp.CA_Name,
                });
        }


        // 顯示金流訂單
        // POST: api/CardOrders (會發現動詞與下面的POST相同而衝突)
        // 需增加參數POST:改為api/CardOrders/Show 而url不同區別
        [HttpPost("Show")]
        public async Task<IEnumerable<CardOrderDTO>> ShowAccountCardOrder([FromBody] CardOrderDTO cardorderDTO)
        {
            var productname = _context.Products.Find(cardorderDTO.CA_ID);
            // return null;
            //return _context.CardOrders
            //    .Where(co => co.A_ID == cardorderDTO.A_ID)
            //    .Select(co => new CardOrderDTO
            //    {
            //        CO_ID = co.CO_ID,
            //        A_ID = co.A_ID,
            //        CA_ID = co.CA_ID,
            //        CT_ID = co.CT_ID,
            //        CO_Sum = co.CO_Sum,
            //        CO_Date = co.CO_Date,
            //        CO_Cancel = co.CO_Cancel,
            //        CO_Quantity = co.CO_Quantity,
            //    });
            return _context.CardOrders
                .Where(co => co.A_ID == cardorderDTO.A_ID)
                .Join(_context.Cards,
                co => co.CA_ID,
                cp => cp.CA_ID,
                (co, cp) => new CardOrderDTO
                {
                    CO_ID = co.CO_ID,
                    A_ID = co.A_ID,
                    CA_ID = co.CA_ID,
                    CT_ID = co.CT_ID,
                    CO_Sum = co.CO_Sum,
                    CO_Date = co.CO_Date,
                    CO_Cancel = co.CO_Cancel,
                    CO_Quantity = co.CO_Quantity,
                    CA_Name = cp.CA_Name,
                });
        }

        //只修改訂單取消
        // PUT: api/CardOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("Cancel/{id}")]
        public async Task<string> PutCardOrders(int id, CardOrderDTO cardOrders)
        {
            if (id != cardOrders.CO_ID)
            {
                //return BadRequest();
                return "讀取記錄發生錯誤!";
            }
            CardOrder co = await _context.CardOrders.FindAsync(id);
            co.CO_Cancel = cardOrders.CO_Cancel;

            _context.Entry(co).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardOrdersExists(id))
                {
                    //return NotFound();
                    return "修改金流訂單紀錄發生錯誤!";
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();
            return "修改紀錄成功";
        }

        // POST: api/CardOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostCardOrders(CardOrderDTO cardOrders)
        {
            if (_context.CardOrders == null)
            {
                //return Problem("Entity set 'ChickenLifeContext.CardOrders'  is null.");
                return "尚無金流訂單紀錄";
            };
            CardOrder co = new CardOrder
            {
                CO_ID = cardOrders.CO_ID,
                A_ID = cardOrders.A_ID,
                CA_ID = cardOrders.CA_ID,
                CT_ID = cardOrders.CT_ID,
                CO_Sum = cardOrders.CO_Sum,
                CO_Date = cardOrders.CO_Date,
                CO_Cancel = false,
                CO_Quantity = cardOrders.CO_Quantity,
            };
            _context.CardOrders.Add(co);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCardOrders", new { id = cardOrders.CO_ID }, cardOrders);
            return "新增紀錄成功";
        }


        private bool CardOrdersExists(int id)
        {
            return (_context.CardOrders?.Any(e => e.CO_ID == id)).GetValueOrDefault();
        }
    }
}
