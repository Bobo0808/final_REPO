

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using ClassLibrary.Models;
using ClassLibrary;

namespace final_repo_test.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeesController : Controller
    {
        private readonly ChickenDbContext _context;

        public EmployeesController(ChickenDbContext context)
        {
            _context = context;
        }

        // GET: Employee/Employees
        public async Task<IActionResult> Index()
        {
            return _context.Employees != null ?
                        View(await _context.Employees.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Employees'  is null.");
        }

        // GET: Employee/Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.E_ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Employees/Create
        public IActionResult Create()
        {
            //return View("~/Areas/Employee/Views/Employees/Create.cshtml");
            return View();
        }

        // POST: Employee/Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("E_ID,E_Name,E_Gender,E_UserName,E_Pwd,E_Email,E_Title,E_Phone,E_Birthday,E_HireDate,E_Address,E_Permission,E_Work")] ClassLibrary.Models.Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View("~/Areas/Employee/Views/Employees/Edit.cshtml", employee);
        }

        // POST: Employee/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("E_ID,E_Name,E_Gender,E_UserName,E_Pwd,E_Email,E_Title,E_Phone,E_Birthday,E_HireDate,E_Address,E_Permission,E_Work")] ClassLibrary.Models.Employee employee)
        {
            if (id != employee.E_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.E_ID))
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
            return View(employee);
        }

        // GET: Employee/Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.E_ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View("~/Areas/Employee/Views/Employees/Delete.cshtml" ,employee);
        }

        // POST: Employee/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employees == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Employees'  is null.");
            }
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return (_context.Employees?.Any(e => e.E_ID == id)).GetValueOrDefault();
        }
    }
}
