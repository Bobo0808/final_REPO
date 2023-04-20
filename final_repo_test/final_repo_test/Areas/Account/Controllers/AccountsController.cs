using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_repo_test.Data;
using final_repo_test.Models;

namespace final_repo_test.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Account/Accounts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = await _context.Accounts.Include(a => a.Product).ToListAsync();
            return View(applicationDbContext);
        }

        // GET: Account/Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Product)
                .FirstOrDefaultAsync(m => m.A_ID == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Account/Accounts/Create
        public IActionResult Create()
        {
            ViewData["P_id"] = new SelectList(_context.Products, "P_ID", "P_Describe");
            return View();
        }

        // POST: Account/Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("A_ID,A_Name,UserName,UserPWD,A_Gender,Birthday,P_id,A_level,A_Email,A_Phone,A_add,A_RegisteredAt,A_NickName,A_Coin")] UserAccount account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["P_id"] = new SelectList(_context.Products, "P_ID", "P_Describe", account.P_id);
            return View(account);
        }

        // GET: Account/Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["P_id"] = new SelectList(_context.Products, "P_ID", "P_Describe", account.P_id);
            return View(account);
        }

        // POST: Account/Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("A_ID,A_Name,UserName,UserPWD,A_Gender,Birthday,P_id,A_level,A_Email,A_Phone,A_add,A_RegisteredAt,A_NickName,A_Coin")] UserAccount account)
        {
            if (id != account.A_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.A_ID))
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
            ViewData["P_id"] = new SelectList(_context.Products, "P_ID", "P_Describe", account.P_id);
            return View(account);
        }

        // GET: Account/Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Product)
                .FirstOrDefaultAsync(m => m.A_ID == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Account/Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accounts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Accounts'  is null.");
            }
            var account = await _context.Accounts.FindAsync(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
          return (_context.Accounts?.Any(e => e.A_ID == id)).GetValueOrDefault();
        }
    }
}
