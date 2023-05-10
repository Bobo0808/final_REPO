using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_repo_test.Data;
using final_repo_test.Models;

namespace final_repo_test.Areas.Report.Controllers
{
    [Area("Report")]
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Report/Report
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reports.Include(r => r.Account).Include(r => r.ReportedAccount);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Report/Report/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reports == null)
            {
                return NotFound();
            }

            var report = await _context.Reports
                .Include(r => r.Account)
                .Include(r => r.ReportedAccount)
                .FirstOrDefaultAsync(m => m.R_ID == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // GET: Report/Report/Create
        public IActionResult Create()
        {
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email");
            ViewData["ReportedA_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email");
            return View();
        }

        // POST: Report/Report/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("R_ID,A_ID,ReportedA_ID,R_Time,R_ReportType,R_Reason,R_ReportStatus,R_Reply")] Models.Report report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email", report.A_ID);
            ViewData["ReportedA_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email", report.ReportedA_ID);
            return View(report);
        }

        // GET: Report/Report/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reports == null)
            {
                return NotFound();
            }

            var report = await _context.Reports.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email", report.A_ID);
            ViewData["ReportedA_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email", report.ReportedA_ID);
            return View(report);
        }

        // POST: Report/Report/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("R_ID,A_ID,ReportedA_ID,R_Time,R_ReportType,R_Reason,R_ReportStatus,R_Reply")] Models.Report report)
        {
            if (id != report.R_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportExists(report.R_ID))
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
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email", report.A_ID);
            ViewData["ReportedA_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Email", report.ReportedA_ID);
            return View(report);
        }

        // GET: Report/Report/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reports == null)
            {
                return NotFound();
            }

            var report = await _context.Reports
                .Include(r => r.Account)
                .Include(r => r.ReportedAccount)
                .FirstOrDefaultAsync(m => m.R_ID == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // POST: Report/Report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reports == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Reports'  is null.");
            }
            var report = await _context.Reports.FindAsync(id);
            if (report != null)
            {
                _context.Reports.Remove(report);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportExists(int id)
        {
          return (_context.Reports?.Any(e => e.R_ID == id)).GetValueOrDefault();
        }
    }
}
