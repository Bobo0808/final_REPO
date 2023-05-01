using final_repo_test.Data;
using Microsoft.AspNetCore.Mvc;
using final_repo_test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace final_repo_test.Areas.OrderProduct.Controllers
{
    [Area(areaName: "OrderProduct")]
    public class ProductsController : Controller
    {
        
        public readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductsController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            if (products == null)
            {
                return Problem("Entity set 'FinalContext.Products' is null.");
            }

            return View("~/Areas/OrderProduct/Views/Products/Index.cshtml", products);
            //return View();
        }
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.P_ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Areas/OrderProduct/Views/Products/Details.cshtml", product);
        }
        // GET: Products/Create
        public IActionResult Create()
        {
            return View("~/Areas/OrderProduct/Views/Products/Create.cshtml");
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("P_ID,P_Name,P_ProductType,P_Price,P_Image,P_Describe,P_Instock,P_Date,P_Discount,P_Discontinuted")] Product product, IFormFile file1)
        {
            //if (ModelState.IsValid)
            //{
            if (file1 != null)
            {
                string PictureName = UploadFile(file1);
                product.P_Image = PictureName;
            }
            else
            {
                product.P_Image = "No_Image_Available.jpg";
            }
            //SetPicture(product);
            _context.Add(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //}
            //return View("~/Areas/OrderProduct/Views/Products/Index.cshtml", product);
        }
        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View("~/Areas/OrderProduct/Views/Products/Edit.cshtml", product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestFormLimits(MultipartBodyLengthLimit = 2048000)]
        public async Task<IActionResult> Edit(int id, [Bind("P_ID,P_Name,P_ProductType,P_Price,P_Image,P_Describe,P_Instock,P_Date,P_Discount,P_Discontinuted")] Product product, IFormFile file1)
        {
            if (id != product.P_ID)
            {
                return NotFound();
            }
            try
            {

                if (file1 != null)
                {
                    string PictureName = UploadFile(file1);
                    product.P_Image = PictureName;
                    _context.Update(product);
                }
                else
                {
                    var imagename = await _context.Products.Where(m => m.P_ID == id).Select(p => p.P_Image).FirstOrDefaultAsync();
                    product.P_Image = imagename;
                    _context.Update(product);
                }


                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(product.P_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

            //return View("~/Areas/OrderProduct/Views/Products/Index.cshtml", product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.P_ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Areas/OrderProduct/Views/Products/Delete.cshtml", product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'FinalContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private bool ProductExists(int id)
        {
            return (_context.Products?.Any(e => e.P_ID == id)).GetValueOrDefault();
        }
        public string UploadFile(IFormFile file1)
        {
            //單一檔案IFormFile
            //複數檔案IFormFileCollection、List<IFormFile>、IEumerable<IFormFile>
            //IFormFile.Name 檔案欄位在表單中的名稱
            //IFormFile.FileName 檔案來源名稱(無路徑)
            //IFormFile.Length 檔案大小

            //檔案儲存路徑
            string strFilePath = _env.ContentRootPath + @"wwwroot\img\producttest\";

            //上傳檔案內容長度>0，表示有檔案上傳
            //if(file1.Length > 0)
            //{
            //宣告隱含變數(取得檔案名
            var varFileName = file1.FileName;

            //開啟或述寫上傳檔案
            using (var varStream = System.IO.File.Create(strFilePath + varFileName))
            {
                //儲存上傳檔案至伺服器
                file1.CopyTo(varStream);
            }
            //}

            return varFileName;
        }

    }
}
