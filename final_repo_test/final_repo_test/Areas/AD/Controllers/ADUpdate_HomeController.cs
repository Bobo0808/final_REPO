﻿using Microsoft.AspNetCore.Mvc;
using final_repo_test.Data;
using final_repo_test.Models;
using final_repo_test.ViewModels.AD.ADUpdate;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Areas.AD.Controllers
{
    [Area(areaName: "AD")]
    public class ADUpdate_HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ADUpdate_HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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
        [HttpPost]
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

        public IActionResult UpdateCase(int id)
        {
            var model = new ADUpdateViewModel
            {
                CaseTablesList = _dbContext.CaseTables.ToList(),
                SelectedCase = _dbContext.CaseTables.FirstOrDefault(x => x.Case_ID == id)
            };

            return View("Index", model);
        }
    }
    //public IActionResult Delete()
    //{

    //}
    //public ActionResult Add() {
    //}
}
