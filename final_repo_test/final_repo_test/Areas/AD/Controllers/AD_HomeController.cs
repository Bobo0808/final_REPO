﻿using Microsoft.AspNetCore.Mvc;
using final_repo_test.Data;
using final_repo_test.Models;
using final_repo_test.ViewModels.AD.AD;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Areas.AD.Controllers
{
	[Area(areaName: "AD")]
	public class AD_HomeController : Controller
	{
		private readonly ApplicationDbContext _dbContext;

		public AD_HomeController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			var partners = _dbContext.Partners.ToList();
			var viewModel = new ADViewModel { PartnersList = partners };
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult DeletePartner(int id)
		{
			try
			{
				var partner = _dbContext.Partners.Find(id);
				if (partner == null)
				{
					return Json(new { success = false });
				}

				_dbContext.Partners.Remove(partner);
				_dbContext.SaveChanges();
				return Json(new { success = true });
			}
			catch (Exception ex)
			{
				return Json(new { success = false });
			}
		}
	}
}