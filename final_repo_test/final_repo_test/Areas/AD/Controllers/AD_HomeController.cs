using Microsoft.AspNetCore.Mvc;
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

		[HttpPost]
		public IActionResult AddPartner(ADViewModel AdViewModel)
		{
			try
			{
				if (AdViewModel.PartnersList == null)
				{
					AdViewModel.PartnersList = new List<Partner>();
				}

				var partner = new Partner
				{
					P_Name = AdViewModel.PartnerName,
					Contact = AdViewModel.Contact,
					Email = AdViewModel.Email,
					Phone = AdViewModel.Phone,
					P_Note = AdViewModel.Note,
				};
				_dbContext.Partners.Add(partner);
				_dbContext.SaveChanges();

				AdViewModel.PartnersList.Add(partner);

				return PartialView("_PartnerTable", AdViewModel.PartnersList);



			}
			catch (System.Exception ex)
			{
				return Json(new { success = false, message = ex.Message });
			}
		}

	}

}

