using ClassLibrary;
using ClassLibrary.ViewModels.AD.AD;
using ClassLibrary.ViewModels.AD.ADUpdate;
using final_repo_test.ViewModels.AD.ADDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Areas.AD.Controllers
{
	[Area(areaName: "AD")]
	public class ADDetail_HomeController : Controller
	{
		private readonly ChickenDbContext _dbContext;

		public ADDetail_HomeController(ChickenDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			var ads = _dbContext.Ads.ToList();
			var viewModel = new ADDetailViewModel { AdsList = ads };
			return View(viewModel);
		}
        public async Task<IActionResult> DeleteAds(int id)
        {
            var model = new ADDetailViewModel
            {
                AdsList = _dbContext.Ads.ToList()
            };
            var AdsTable = _dbContext.Ads.Find(id);
            if (AdsTable == null)
            {
                return View("Index", model);
            }
            _dbContext.Ads.Remove(AdsTable);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //[Route("AD/Case/{id}")]
        //public async Task<IActionResult> GetModel(int id)
        //{
        //	var model = new ADDetailViewModel
        //	{

        //		SelectedCase = _dbContext.CaseTables.FirstOrDefault(x => x.Case_ID == id),
        //		AdsList =  _dbContext.Ads.ToList()
        //	};
        //	return View("Index", model);
        //}
    }
}