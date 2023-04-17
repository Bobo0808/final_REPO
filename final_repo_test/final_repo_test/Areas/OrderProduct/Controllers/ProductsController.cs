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
    //[Area(areaName:"Products")]
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

            return View("~/Areas/OrderProduct/Views/Products/Index.cshtml",products);
            //return View();
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
        public async Task<IActionResult> Create([Bind("PId,PName,PType,PPrice,PImage,PDescribe,PInstock,PDate,PDiscount,PDiscontinuted")] Product product, IFormFile file1)
        {
            if (ModelState.IsValid)
            {
                if (file1 != null)
                {
                    string PictureName = UploadFile(file1);
                    product.P_Image = PictureName;
                }
                //SetPicture(product);
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("~/Areas/OrderProduct/Views/Products/Index.cshtml", product);
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
            string strFilePath = _env.ContentRootPath + @"wwwroot\images\";

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
