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
    public class CardsController : ControllerBase
    {
        private readonly ChickenDbContext _context;

        public CardsController(ChickenDbContext context)
        {
            _context = context;
        }

        // GET: api/Cards
        [HttpGet]
        public IEnumerable<CardDTO> GetCards()
        {
            //return await _context.Products.ToListAsync();
            return _context.Cards.Where(card => card.CA_Discontinuted == false).Select(card => new CardDTO
            {
                CA_ID = card.CA_ID,
                CA_Name = card.CA_Name,
                CA_Price = card.CA_Price,
                CA_Image = card.CA_Image,
                CA_Describe = card.CA_Describe,
                CA_Date = card.CA_Date,
                CA_Discontinuted = card.CA_Discontinuted,
            });
        }
        ////// 篩選
        ////// POST: api/Cards (會發現動詞與下面的POST相同而衝突)
        ////// 需增加參數POST:改為api/Employees/Filter 而url不同區別
        [HttpPost("Filter")]
        public async Task<IEnumerable<CardDTO>> FilterCard([FromBody] CardDTO cardDTO)
        {
            // return null;
            return _context.Cards
                .Where(card => card.CA_ID == cardDTO.CA_ID ||
                              card.CA_Name.Contains(cardDTO.CA_Name) ||
                              card.CA_Price.ToString().Contains(cardDTO.CA_Price.ToString()))
                .Select(card => new CardDTO
                {
                    CA_ID = card.CA_ID,
                    CA_Name = card.CA_Name,
                    CA_Price = card.CA_Price,
                    CA_Image = card.CA_Image,
                    CA_Describe = card.CA_Describe,
                    CA_Date = card.CA_Date,
                    CA_Discontinuted = card.CA_Discontinuted,
                });
        }
        // GET: api/Cards/5
        [HttpGet("{id}")]
        public async Task<CardDTO> GetCards(int id)
        {
            var cards= await _context.Cards.FindAsync(id);

            return new CardDTO
            {
                CA_ID = cards.CA_ID,
                CA_Name = cards.CA_Name,
                CA_Price = cards.CA_Price,
                CA_Image = cards.CA_Image,
                CA_Describe = cards.CA_Describe,
                CA_Date = cards.CA_Date,
                CA_Discontinuted = cards.CA_Discontinuted,
            };
        }

        // PUT: api/Cards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<string> PutCards(int id, CardDTO cardDTO)
        {
            if (id != cardDTO.CA_ID)
            {
                //return NotFound();
                return "讀取記錄發生錯誤!";
            }
            //Card cards = await _context.Cards.FindAsync(id);
            //cards.CA_ID = cardDTO.CA_ID;
            //cards.CA_Name = cardDTO.CA_Name;
            //cards.CA_Price = cardDTO.CA_Price;
            //cards.CA_Image = cardDTO.CA_Image;
            //cards.CA_Describe = cardDTO.CA_Describe;
            //cards.CA_Date = cardDTO.CA_Date;
            //cards.CA_Discontinuted = cardDTO.CA_Discontinuted;

            //_context.Entry(cards).State = EntityState.Modified;

            Card cards = await _context.Cards.FindAsync(id);
            cards.CA_ID = cardDTO.CA_ID;
            cards.CA_Name = cardDTO.CA_Name;
            cards.CA_Price = cardDTO.CA_Price;
            cards.CA_Image = cardDTO.CA_Image;
            cards.CA_Describe = cardDTO.CA_Describe;
            cards.CA_Date = cardDTO.CA_Date;
            cards.CA_Discontinuted = cardDTO.CA_Discontinuted;

            _context.Entry(cards).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardsExists(id))
                {
                    return "修改金流紀錄發生錯誤";
                    //return NotFound();
                }
            }


            return "修改成功";
        }

        // POST: api/Cards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostCards(CardDTO cards)
        {
          if (_context.Cards == null)
          {
                //return Problem("Entity set 'ChickenLifeContext.Cards'  is null.");
                return "尚無金流紀錄";
          }
            Card cd= new Card
            {
                CA_ID = cards.CA_ID,
                CA_Name = cards.CA_Name,
                CA_Price = cards.CA_Price,
                CA_Image = cards.CA_Image,
                CA_Describe = cards.CA_Describe,
                CA_Date = cards.CA_Date,
                CA_Discontinuted = cards.CA_Discontinuted,
            };
            _context.Cards.Add(cd);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCards", new { id = cards.CA_ID }, cards);
            return "新增成功";
        }

       

        private bool CardsExists(int id)
        {
            return (_context.Cards?.Any(e => e.CA_ID == id)).GetValueOrDefault();
        }
    }
}
