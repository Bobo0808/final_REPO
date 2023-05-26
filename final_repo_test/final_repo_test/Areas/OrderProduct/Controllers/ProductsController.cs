using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClassLibrary;
using ClassLibrary.Enum;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using ClassLibrary.ViewModels;
using final_repo_test.Interfaces;

namespace final_repo_test.Areas.OrderProduct.Controllers
{
    [Area(areaName: "OrderProduct")]
    public class ProductsController : Controller
    {

        public readonly ChickenDbContext _context;
        private readonly IWebHostEnvironment _env;
        //圖片設定
        private readonly IPhotoService _photoService;


        public ProductsController(ChickenDbContext context, IWebHostEnvironment env, IPhotoService photoService)
        {
            _context = context;
            _env = env;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index(int id = 1)
        {
            var products = await _context.Products.ToListAsync();
            if (products == null)
            {
                return Problem("Entity set 'FinalContext.Products' is null.");
            }

            // return View("~/Areas/OrderProduct/Views/Products/Index.cshtml", products);
            //return View();
            int PageSize = 4;

            // RecordCount變數，符合條件的總共有幾筆記錄？
            int RecordCount = _context.Products.Count();

            // NowPageCount 目前正在觀賞這一頁紀錄，目前正在?
            int NowPageCount = 0;
            if (id > 0)
            {
                NowPageCount = (int)((id - 1) * PageSize);
            }
            // orderby順排序 descending反排序
            // skip從哪裡開始(忽略前面幾筆紀錄)
            var ListAll = (from product in _context.Products
                           orderby product.P_ID
                           select product)
                         .Skip(NowPageCount)
                         .Take(PageSize);
            //*** 查詢結果 ListAll 是一個 IQueryable ***
            ////if (ListAll == null) // 查無資料時，無法正確運作。因為 IQueryable<T>會傳回一個「空集合」而不是「空（null）。所以這段if辨別不了」
            if (ListAll.Any() == false)  // 可運作
            ////if (ListAll.GetEnumerator().MoveNext() == false)   // 可運作
            {   // 找不到任何記錄。 .NET Core改用 NotFound();
                return NotFound();
            }
            else
            {
                #region
                // Pages變數，「總共需要幾頁」才能把所有紀錄展示完畢？
                int Pages;
                if ((RecordCount % PageSize) > 0)
                {   //-- %，除法，傳回餘數
                    Pages = ((RecordCount / PageSize) + 1);   //-- ( / )除法。傳回整數。  如果無法整除，有餘數，則需要多出一頁來呈現。 
                }
                else
                {
                    Pages = (RecordCount / PageSize);   //-- ( /)除法。傳回整數
                }



                System.Text.StringBuilder sbPageList = new System.Text.StringBuilder();
                if (Pages > 0)
                {   //有傳來「頁數(p)」，而且頁數正確（大於零），出現<上一頁>、<下一頁>這些功能
                    sbPageList.Append("<div align='center'>");

                    //** 可以把檔名刪除，只留下 ?P=  即可！一樣會運作，但IE 11會出現 JavaScript錯誤。**
                    //** 抓到目前網頁的「檔名」。 System.IO.Path.GetFileName(Request.PhysicalPath) **
                    if (id > 1)
                    {   //======== 分頁功能（上一頁 / 下一頁）=========start===                
                        sbPageList.Append("<a href='?id=" + (id - 1) + "'>[<<<上一頁]</a>");
                    }
                    sbPageList.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b><a href='https://backsite.azurewebsites.net/OrderProduct/Products'>[首頁]</a></b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                    if (id < Pages)
                    {
                        sbPageList.Append("<a href='?id=" + (id + 1) + "'>[下一頁>>>]</a>");
                    }  //======== 分頁功能（上一頁 / 下一頁）=========end====


                    //==========================================================
                    //========= MIS2000 Lab.自製的「每十頁」一間隔，分頁功能=========start====
                    sbPageList.Append("<p hight:'5px' width='97%' size=1></p>");

                    int block_page = 0;
                    block_page = id / 10;   //--只取除法的整數成果（商），若有餘數也不去管它。

                    if (block_page > 0)
                    {
                        sbPageList.Append("<a href='?id=" + (((block_page - 1) * 10) + 9) + "'> [前十頁<<]  </a>&nbsp;&nbsp;");
                    }

                    for (int K = 0; K <= 10; K++)
                    {
                        if ((block_page * 10 + K) <= Pages)
                        {   //--- Pages 資料的總頁數。共需「幾頁」來呈現所有資料？
                            if (((block_page * 10) + K) == id)
                            {   //--- id 就是「目前在第幾頁」
                                sbPageList.Append("[<b>" + id + "</b>]" + "&nbsp;&nbsp;&nbsp;");
                            }
                            else
                            {
                                if (((block_page * 10) + K) != 0)
                                {
                                    sbPageList.Append("<a href='?id=" + (block_page * 10 + K) + "'>" + (block_page * 10 + K) + "</a>");
                                    sbPageList.Append("&nbsp;&nbsp;&nbsp;");
                                }
                            }
                        }
                    }  //for迴圈 end

                    if ((block_page < (Pages / 10)) & (Pages >= (((block_page + 1) * 10) + 1)))
                    {
                        sbPageList.Append("&nbsp;&nbsp;<a href='?id=" + ((block_page + 1) * 10 + 1) + "'>  [>>後十頁]  </a>");
                    }
                    sbPageList.Append("</div>");
                }
                #endregion

                ViewBag.PageList = sbPageList.ToString();
                return View(ListAll.ToList());
            }
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
            //ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name");
            //ViewData["P_ProductType"] = new SelectList(Enum.GetValues(typeof(ProductType))
            //                                .Cast<ProductType>()
            //ViewData["A_ID"] = Enum.GetValues(typeof(ProductType))
            //                        .Cast<ProductType>()
            //                        .Select(t => new { Value = (int)t, Text = t.ToString() })
            //                        .ToList();

            var productTypes = Enum.GetValues(typeof(ProductType))
                                    .Cast<ProductType>()
                                    .Select(t => new { Value = (int)t, Text = t.ToString() })
                                    .ToList();

            ViewBag.P_ProductType = new SelectList(productTypes, "Value", "Text");
            return View("~/Areas/OrderProduct/Views/Products/Create.cshtml");
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("P_ID,P_Name,P_ProductType,P_Price,P_Image,P_Describe,P_Instock,P_Date,P_Discount,P_Discontinuted")] Product product, IFormFile file1)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    if (file1 != null)
        //    {
        //        string PictureName = UploadFile(file1);
        //        product.P_Image = PictureName;
        //    }
        //    else
        //    {
        //        product.P_Image = "No_Image_Available.jpg";
        //    }
        //    //SetPicture(product);
        //    _context.Add(product);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //    //}
        //    //return View("~/Areas/OrderProduct/Views/Products/Index.cshtml", product);
        //}

        //Cloudinary
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("P_ID,P_Name,P_ProductType,P_Price,P_Image,P_Describe,P_Instock,P_Date,P_Discount,P_Discontinuted")] Product product, IFormFile file1)
        {
            //if (ModelState.IsValid)
            //{

            if (file1 != null)
            {
                var result = await _photoService.AddPhotoAsync(file1);
                string PictureName = result.Url.ToString();
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

            var productTypes = Enum.GetValues(typeof(ProductType))
                                    .Cast<ProductType>()
                                    .Select(t => new { Value = (int)t, Text = t.ToString() })
                                    .ToList();

            ViewBag.P_ProductType = new SelectList(productTypes, "Value", "Text");

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
                    //string PictureName = UploadFile(file1);
                    //product.P_Image = PictureName;
                    var result = await _photoService.AddPhotoAsync(file1);
                    string PictureName = result.Url.ToString();
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
            //var varFileName = file1.FileName;
            var varFileName = GenerateRandomFileName(file1.FileName);

            //開啟或述寫上傳檔案
            using (var varStream = System.IO.File.Create(strFilePath + varFileName))
            {
                //儲存上傳檔案至伺服器
                file1.CopyTo(varStream);
            }
            //}

            return varFileName;
        }



        private string GenerateRandomFileName(string originalFileName)
        {
            // 使用亂數產生新的檔案名稱，保留原始檔案的副檔名
            string fileExtension = Path.GetExtension(originalFileName);

            string randomFileName = Guid.NewGuid().ToString("N") + fileExtension;

            return randomFileName;
        }

    }
}
