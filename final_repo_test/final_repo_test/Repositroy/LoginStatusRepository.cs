using ClassLibrary;
using final_repo_test.Interfaces;
using ClassLibrary.ViewModels.LoginStatus;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Repositroy
{
    public class LoginStatusRepository : ILoginStatusRepository
    {
        private readonly ChickenDbContext _context;

        public LoginStatusRepository(ChickenDbContext context)
        {
            _context = context;
        }

        public async Task<GetDayViewModel> GetDay(string Chart)
        {
            
            GetDayViewModel result = new GetDayViewModel();
            result.Unit = Chart.ToLower();
            int itemp = 1;
            //處理AD資料
            //var coolName = await _context.Ads.Where(s => s.Ad_EndTime > DateTime.Now && s.Ad_StartTime < DateTime.Now).OrderByDescending(s => s.Ad_Clicks).Select(s => new { MyID = s.Ad_ID, MyClicks = s.Ad_Clicks }).ToListAsync();
            var adtemp = await _context.Ads.OrderByDescending(s => s.Ad_Clicks).Select(s => new { MyID = s.Partner, MyClicks = s.Ad_Clicks }).Take(5).ToListAsync();
            for (int i = 0; i < adtemp.Count; i++)
            {
                result.ADx.Add(adtemp[i].MyID.P_Name);
                result.ADy.Add(adtemp[i].MyClicks);
            }

            //var producttemp = await _context.OrderDetails.GroupBy(s => s.Product.P_Name, s =>s.Od_Sum).Select(x=> new{MyID=x.Key,MyPrice=x.Sum()}).ToListAsync();
            var producttemp = await _context.OrderDetails.Where(s=>s.Order.O_Cancle==false&&s.Order.O_Date.Month==DateTime.Now.Month).GroupBy(s => s.Product.P_Name, s => s.Od_Sum).Select(x => new { MyID = x.Key, MyPrice = x.Sum() }).ToListAsync();
            for (int i = 0; i < producttemp.Count; i++)
            {
                result.Productx.Add(producttemp[i].MyID);
                result.Producty.Add(producttemp[i].MyPrice);
            }

            var salestemp = await _context.CardOrders.Where(s => s.CO_Cancel == false && s.CO_Date >= DateTime.Now.AddMonths(-6)).GroupBy(s => new { s.CO_Date.Month ,s.CO_Date.Year}, s => s.CO_Sum).Select(x => new { MyMonth = x.Key.Month,MyYear=x.Key.Year, MySales = x.Sum() }).ToListAsync();
            for (int i = 0; i < salestemp.Count; i++)
            {
                result.Salesx.Add($"{salestemp[i].MyYear}年{ salestemp[i].MyMonth}月");
                result.Salesy.Add(salestemp[i].MySales);
            }

            for (int i = 0; i < result.Headx.Count; i++)
            {
                if (itemp < result.Headx.Count)
                {
                    result.Heady.Add((await _context.LoginStaus.Where(s => s.L_cTime.TimeOfDay >= result.Headx[i] && s.L_cTime.TimeOfDay <= result.Headx[itemp]).ToListAsync()).Count);
                }
                else
                {
                    result.Heady.Add((await _context.LoginStaus.Where(s => s.L_cTime.TimeOfDay >= result.Headx[i]).ToListAsync()).Count);
                }
                itemp++;
            }
            switch (Chart)
            {
                case "Day":
                    DateTime tempDay = DateTime.Now.AddDays(-6);
                    var list = await _context.LoginStaus.Where(s => s.L_cTime > tempDay).ToListAsync();

                    result.Average = (int)Math.Round(list.Sum(x => (x.L_dcTime.Subtract(x.L_cTime).TotalHours)) / list.Count);
                    result.UserCount = list.GroupBy(x => x.A_ID).Count();
                    for(int i = -6; i <= 0; i++)
                    {
                        result.Mainx.Add(DateTime.Now.AddDays(i));
                        result.Mainy.Add(_context.LoginStaus.Where(s => s.L_cTime.Day == DateTime.Now.AddDays(i).Day).Count());
                    }
                   
                    break;
                case "Week":
                    DateTime tempWeek = DateTime.Now.AddDays(-42);
                    var listWeek = await _context.LoginStaus.Where(s => s.L_cTime > tempWeek).ToListAsync();
                    result.Average = (int)Math.Round(listWeek.Sum(x => (x.L_dcTime.Subtract(x.L_cTime).TotalHours)) / listWeek.Count);
                    result.UserCount = listWeek.GroupBy(x => x.A_ID).Count();
                    int jtemp = -42 + 7;
                    for (int i = -42; i <= 0; i+=7)
                    {
                        
                        result.Mainx.Add(DateTime.Now.AddDays(i));
                        result.Mainy.Add(_context.LoginStaus.Where(s => s.L_cTime >= DateTime.Now.AddDays(i)&& s.L_cTime < DateTime.Now.AddDays(jtemp)).Count());
                        jtemp += 7;
                    }

                    break;
                case "Month":
                    DateTime tempMonth = DateTime.Now.AddMonths(-7);
                    var listMonth = await _context.LoginStaus.Where(s => s.L_cTime > tempMonth).ToListAsync();
                    result.Average = (int)Math.Round(listMonth.Sum(x => (x.L_dcTime.Subtract(x.L_cTime).TotalHours)) / listMonth.Count);
                    result.UserCount = listMonth.GroupBy(x => x.A_ID).Count();
                    for (int i = -6; i <= 0; i ++)
                    {
                        result.Mainx.Add(DateTime.Now.AddMonths(i));
                        result.Mainy.Add(_context.LoginStaus.Where(s => s.L_cTime.Month == DateTime.Now.AddMonths(i).Month).Count());
                    }
                    break;
            }
           
            return result;
        }
    }
}
