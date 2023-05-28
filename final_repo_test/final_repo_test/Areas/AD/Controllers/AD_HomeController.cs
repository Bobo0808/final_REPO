using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Models;
using ClassLibrary.ViewModels.AD.AD;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ClassLibrary;

namespace final_repo_test.Areas.AD.Controllers
{
    [Area(areaName: "AD")]
	public class AD_HomeController : Controller
	{
		private readonly ChickenDbContext _dbContext;

		public AD_HomeController(ChickenDbContext dbContext)
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

		[HttpPost]
		[ValidateAntiForgeryToken]
		public JsonResult AddPartner(string PartnerName, string Contact, string Email, string Phone, string Note)
		{
			try
			{
				var partner = new Partner()
				{
					P_Name = PartnerName,
					Contact = Contact,
					Email = Email,
					Phone = Phone,
					P_Note = Note,
				};

				_dbContext.Partners.Add(partner);
				_dbContext.SaveChanges();


				var partners = _dbContext.Partners.ToList();
				return Json(new { success = true, partners = partners });
			}
			catch (System.Exception ex)
			{
				return Json(new { success = false, message = ex.Message });
			}
		}

		[HttpGet]
		public IActionResult GetPartners()
		{
			var partners = _dbContext.Partners.ToList();
			return Json(partners);
		}
	}
}