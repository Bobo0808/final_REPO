using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using ClassLibrary;

namespace final_repo_test.Areas.CardOrderProduct.Controllers
{
    //[Area("CardOrderProduct")]
    [Area(areaName: "CardOrderProduct")]
    public class CardOrdersController : Controller
    {
        private readonly ChickenDbContext _context;

        public CardOrdersController(ChickenDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //GET: CardOrderProduct/CardOrders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CardOrders.Include(c => c.Account).Include(c => c.Card).Include(c => c.CardType);
            return View(await applicationDbContext.ToListAsync());
        }

        //GET: CardOrderProduct/CardOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CardOrders == null)
            {
                return NotFound();
            }

            var cardOrder = await _context.CardOrders
                .Include(c => c.Account)
                .Include(c => c.Card)
                .Include(c => c.CardType)
                .FirstOrDefaultAsync(m => m.CO_ID == id);
            if (cardOrder == null)
            {
                return NotFound();
            }

            return View(cardOrder);
            //return PartialView("_ShowCardOrderPartial", cardOrder); ;
        }

        // GET: CardOrderProduct/CardOrders/Create
        public IActionResult Create()
        {
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name");
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name");
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name");
            return View();
        }

        // POST: CardOrderProduct/CardOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_ID,A_ID,CA_ID,CT_ID,CO_Cancel,CO_Date,CO_Sum,CO_Quantity")] CardOrder cardOrder)
        {
            //if (ModelState.IsValid)
            // {
            _context.Add(cardOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //}
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name", cardOrder.A_ID);
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name", cardOrder.CA_ID);
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name", cardOrder.CT_ID);
            //return View(cardOrder);
        }

        // GET: CardOrderProduct/CardOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CardOrders == null)
            {
                return NotFound();
            }

            var cardOrder = await _context.CardOrders.FindAsync(id);
            if (cardOrder == null)
            {
                return NotFound();
            }
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name", cardOrder.A_ID);
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name", cardOrder.CA_ID);
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name", cardOrder.CT_ID);
            return View(cardOrder);
        }

        // POST: CardOrderProduct/CardOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CO_ID,A_ID,CA_ID,CT_ID,CO_Cancel,CO_Date,CO_Sum,CO_Quantity")] CardOrder cardOrder)
        {
            if (id != cardOrder.CO_ID)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(cardOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardOrderExists(cardOrder.CO_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name", cardOrder.A_ID);
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name", cardOrder.CA_ID);
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name", cardOrder.CT_ID);
            //return View(cardOrder);
        }

        // GET: CardOrderProduct/CardOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CardOrders == null)
            {
                return NotFound();
            }

            var cardOrder = await _context.CardOrders
                .Include(c => c.Account)
                .Include(c => c.Card)
                .Include(c => c.CardType)
                .FirstOrDefaultAsync(m => m.CO_ID == id);
            if (cardOrder == null)
            {
                return NotFound();
            }

            return View(cardOrder);
        }

        // POST: CardOrderProduct/CardOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CardOrders == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CardOrders'  is null.");
            }
            var cardOrder = await _context.CardOrders.FindAsync(id);
            if (cardOrder != null)
            {
                _context.CardOrders.Remove(cardOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardOrderExists(int id)
        {
            return (_context.CardOrders?.Any(e => e.CO_ID == id)).GetValueOrDefault();
        }
    }
}
