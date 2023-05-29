using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using ClassLibrary;
using System.Security.Cryptography;
using System.Text;

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
            //if (ModelState.IsValid)
            //{
            //    _context.Add(employee);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(employee);
            if (ModelState.IsValid)
            {
                // 使用 SHA256 算法進行雜湊加鹽
                using (SHA256 sha256 = SHA256.Create())
                {
                    // 將密碼和隨機的鹽值進行結合
                    string salt = GenerateSalt(); // 生成隨機的鹽值
                    string hashedPassword = HashPassword(employee.E_Pwd, salt); // 雜湊加鹽的密碼

                    // 將加密後的密碼存儲到資料庫中
                    employee.E_Pwd = hashedPassword;
                    //employee.Salt = salt;
                }

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        // 生成隨機的鹽值
        private string GenerateSalt()
        {
            byte[] randomBytes = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }

        // 雜湊加鹽的密碼
        private string HashPassword(string password, string salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] combinedBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, combinedBytes, passwordBytes.Length, saltBytes.Length);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashedBytes);
            }
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
            //if (id != employee.E_ID)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(employee);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!EmployeeExists(employee.E_ID))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(employee);
            if (id != employee.E_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // 檢查是否要更新密碼
                if (!string.IsNullOrEmpty(employee.E_Pwd))
                {
                    // 使用 SHA256 算法進行雜湊加鹽
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        // 將新密碼和隨機的鹽值進行結合
                        string salt = GenerateSalt(); // 生成隨機的鹽值
                        string hashedPassword = HashPassword(employee.E_Pwd, salt); // 雜湊加鹽的密碼

                        // 更新加密後的密碼和鹽值
                        employee.E_Pwd = hashedPassword;
                        //employee.Salt = salt;
                    }
                }

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


        //sandy密碼比對筆記
        public string Sandy(int id, [Bind("E_ID,E_Name,E_Gender,E_UserName,E_Pwd,E_Email,E_Title,E_Phone,E_Birthday,E_HireDate,E_Address,E_Permission,E_Work")] ClassLibrary.Models.Employee employee) {
            // 輸入的密碼
            string inputPassword = "輸入的密碼";

            // 從資料庫中獲取存儲的密碼和鹽值
            string hashedPasswordFromDatabase = employee.E_Pwd;
            //string saltFromDatabase = employee.Salt;資料庫無鹽要存鹽
            string saltFromDatabase = employee.E_Pwd;

            // 將輸入的密碼與存儲的密碼進行比對
            string hashedInputPassword = HashPassword(inputPassword, saltFromDatabase);
            bool isPasswordMatch = string.Equals(hashedPasswordFromDatabase, hashedInputPassword);

            if (isPasswordMatch)
            {
                // 密碼匹配，進行相應的操作
            }
            else
            {
                // 密碼不匹配，顯示錯誤訊息或執行相應的處理
            }
            return ("~/Areas/Employee/Views/Employees/Delete.cshtml");
        }

    }
}
