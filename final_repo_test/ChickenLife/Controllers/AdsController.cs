using ChickenLife.Models.OrderProduct;
using ClassLibrary;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Models;
namespace ChickenLife.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : Controller
    {
        private readonly ChickenDbContext _context;
        public AdsController(ChickenDbContext context)
        {
            _context = context;
        }
        //[HttpGet("AdsGet")]
        [HttpGet]
        public IEnumerable<Ads> AdsGet()
        {
            //return await _context.Products.ToListAsync();
            return _context.Ads.Select(ads => new Ads
            {
                Ad_ID = ads.Ad_ID,
                PartnerID = ads.PartnerID,
                CaseID = ads.CaseID,
                Ad_StartTime = ads.Ad_StartTime,
                Ad_EndTime = ads.Ad_EndTime,
                Ad_DayCount = ads.Ad_DayCount,
                Ad_ImageURL = ads.Ad_ImageURL,
                Ad_TargetURL = ads.Ad_TargetURL,
                Ad_Clicks = ads.Ad_Clicks,
                Ad_Description = ads.Ad_Description,
                Ad_PaymentDueDate = ads.Ad_PaymentDueDate,
                Ad_TimeOfPayment = ads.Ad_TimeOfPayment,
                Ad_ActiveStatus = ads.Ad_ActiveStatus,
                OS_ID = ads.OS_ID,
                AD_FinalPaymentAmount = ads.AD_FinalPaymentAmount
            });
        }
    }
}
