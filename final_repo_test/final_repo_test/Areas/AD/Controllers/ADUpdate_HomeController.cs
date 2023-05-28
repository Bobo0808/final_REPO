using Microsoft.AspNetCore.Mvc;
using ClassLibrary;
using ClassLibrary.Models;
using ClassLibrary.ViewModels.AD.ADUpdate;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using final_repo_test.Interfaces;
using final_repo_test.Services;

namespace final_repo_test.Areas.AD.Controllers
{
    [Area(areaName: "AD")]
    public class ADUpdate_HomeController : Controller
    {
        private readonly ChickenDbContext _dbContext;
        private readonly IWebHostEnvironment _env;
        private readonly IPhotoService _photoService;

        public ADUpdate_HomeController(ChickenDbContext dbContext, IWebHostEnvironment env, IPhotoService photoService)
        {
            _dbContext = dbContext;
            _env = env;
            _photoService = photoService;
        }

        public IActionResult Index()
        {
            var viewModel = new ADUpdateViewModel
            {
                AdsList = _dbContext.Ads.ToList(),
                OrderStatusesList = _dbContext.Ads_OrderStatuses.ToList(),
                CaseTablesList = _dbContext.CaseTables.ToList(),
                ADAreaList = _dbContext.Map_ADAreas.ToList(),
                PartnersList = _dbContext.Partners.ToList()
            };

            return View(viewModel);
        }

        //public IActionResult UpdateCase(CaseTable CaseTablesList)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        _dbContext.Entry(CaseTablesList).State = EntityState.Modified;
        //        _dbContext.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(CaseTablesList);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCase(int id, string caseName, int casePrice)
        {
            var caseTable = _dbContext.CaseTables.FirstOrDefault(x => x.Case_ID == id);
            if (caseTable != null)
            {
                caseTable.Case_Name = caseName;
                caseTable.Case_PricePerDay = casePrice;

                _dbContext.Entry(caseTable).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("AD/Case/{id}")]
        public async Task<IActionResult> GetCase(int id)
        {
            var model = new ADUpdateViewModel
            {
                CaseTablesList = await _dbContext.CaseTables.ToListAsync(),
                SelectedCase = _dbContext.CaseTables.FirstOrDefault(x => x.Case_ID == id),
                PartnersList = await _dbContext.Partners.ToListAsync(),
                AdsList = await _dbContext.Ads.ToListAsync(),
                OrderStatusesList = await _dbContext.Ads_OrderStatuses.ToListAsync(),
                ADAreaList = await _dbContext.Map_ADAreas.ToListAsync(),
            };

            return View("Index", model);
        }

        public async Task<IActionResult> DeleteCase(int id)
        {
            var model = new ADUpdateViewModel
            {
                CaseTablesList = await _dbContext.CaseTables.ToListAsync(),
                SelectedCase = _dbContext.CaseTables.FirstOrDefault(x => x.Case_ID == id),
                PartnersList = await _dbContext.Partners.ToListAsync(),
                AdsList = await _dbContext.Ads.ToListAsync(),
                OrderStatusesList = await _dbContext.Ads_OrderStatuses.ToListAsync(),
                ADAreaList = await _dbContext.Map_ADAreas.ToListAsync(),
            };
            var CaseTable = _dbContext.CaseTables.Find(id);
            if (CaseTable == null)
            {
                return View("Index", model);
            }
            _dbContext.CaseTables.Remove(CaseTable);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCase(string caseName, int? casePrice)
        {
            if (caseName == null || casePrice == null)
            {
                return RedirectToAction("Index");
            }
            int price;
            if (!int.TryParse(casePrice.ToString(), out price))
            {
                return RedirectToAction("Index");
            }
            var caseTable = new CaseTable()
            {
                Case_Name = caseName,
                Case_PricePerDay = (int)casePrice
            };

            // 將新的 caseTable 加入資料庫
            _dbContext.CaseTables.Add(caseTable);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAD(string P_Name, string Case_Name, DateTime Ad_StartTime, DateTime Ad_EndTime, IFormFile ADImg, string Ad_TargetURL, string Ad_Description, DateTime Ad_PaymentDueDate)
        {
            if (string.IsNullOrEmpty(P_Name) || P_Name == "選擇廠商...")
            {
                return RedirectToAction("Index");
            }
            if (string.IsNullOrEmpty(Case_Name) || Case_Name == "選擇方案...")
            {
                return RedirectToAction("Index");
            }

            var Partner = _dbContext.Partners.FirstOrDefault(x => x.P_Name == P_Name);
            var CaseName = _dbContext.CaseTables.FirstOrDefault(x => x.Case_Name == Case_Name);

            var ads = new Ads()
            {
                PartnerID = Partner.P_ID,
                CaseID = CaseName.Case_ID,
                Ad_StartTime = Ad_StartTime,
                Ad_EndTime = Ad_EndTime,
                Ad_TargetURL = Ad_TargetURL,
                Ad_Description = Ad_Description,
                Ad_PaymentDueDate = Ad_PaymentDueDate,
                OS_ID = 1,
            };
            if (ADImg != null)
            {
                var result = await _photoService.AddPhotoAsync(ADImg);
                string ADImgName = result.Url.ToString();
                ads.Ad_ImageURL = ADImgName;
            }
            else
            {
                ads.Ad_ImageURL = "no_img.png";
            }
            _dbContext.Ads.Add(ads);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //public string UploadFile(IFormFile ADImg)
        //{
        //    string ImgFilePath = _env.ContentRootPath + @"wwwroot\img\AD\";
        //    var ImgFileName = ADImg.FileName;
        //    using (var Stream = System.IO.File.Create(ImgFilePath + ImgFileName))
        //    {
        //        ADImg.CopyTo(Stream);
        //    }
        //    return ImgFileName;
        //}
    }

    //public IActionResult Delete()
    //{
    //}
    //public ActionResult Add() {
    //}
}