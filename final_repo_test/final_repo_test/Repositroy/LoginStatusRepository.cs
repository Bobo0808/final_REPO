using final_repo_test.Data;
using final_repo_test.Interfaces;
using final_repo_test.ViewModels.LoginStatus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Repositroy
{
    public class LoginStatusRepository : ILoginStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public LoginStatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<GetAverageViewModel> GetAverage()
        {
            var list = await _context.LoginStaus.ToListAsync();
            double temp = 0;
            GetAverageViewModel result = new GetAverageViewModel();
            for (int i  = 0; i < list.Count; i++)
            {
                temp += (list[i].L_dcTime.Subtract(list[i].L_cTime).TotalHours);
            }
            result.Average = Convert.ToInt32(temp);
            return result;
        }

        public async Task<GetTimeViewModel> GetTime()
        {
            var list = await _context.LoginStaus.ToListAsync();
            GetTimeViewModel result = new GetTimeViewModel();
            return result;
        }

        public async Task<GetTotalCountViewModel> GetTotalCount()
        {
            var list = await _context.LoginStaus.ToListAsync();
            GetTotalCountViewModel result = new GetTotalCountViewModel();
            return result;
        }

        public async Task<GetDayViewModel> GetDay(string Chart)
        {
            
            GetDayViewModel result = new GetDayViewModel();
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
                        result.Mainy.Add((await _context.LoginStaus.Where(s => s.L_cTime.Day == DateTime.Now.AddDays(i).Day).ToListAsync()).Count);
                    }
                    int itemp = 1;
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
                    break;
                case "Week":
                    DateTime tempWeek = DateTime.Now.AddDays(-48);
                    var listWeek = await _context.LoginStaus.Where(s => s.L_cTime > tempWeek).ToListAsync();
                    result.Average = (int)Math.Round(listWeek.Sum(x => (x.L_dcTime.Subtract(x.L_cTime).TotalHours)) / listWeek.Count);
                    result.UserCount = listWeek.GroupBy(x => x.A_ID).Count();
                    for (int i = -6; i <= 0; i++)
                    {
                        result.Mainx.Add(DateTime.Now.AddDays(i));
                        result.Mainy.Add((await _context.LoginStaus.Where(s => s.L_cTime.Day == DateTime.Now.AddDays(i).Day).ToListAsync()).Count);
                    }
                    int jtemp = 1;
                    for (int i = 0; i < result.Headx.Count; i++)
                    {
                        if (jtemp < result.Headx.Count)
                        {
                            result.Heady.Add((await _context.LoginStaus.Where(s => s.L_cTime.TimeOfDay >= result.Headx[i] && s.L_cTime.TimeOfDay <= result.Headx[jtemp]).ToListAsync()).Count);
                        }
                        else
                        {
                            result.Heady.Add((await _context.LoginStaus.Where(s => s.L_cTime.TimeOfDay >= result.Headx[i]).ToListAsync()).Count);
                        }
                        jtemp++;
                    }
                    break;
                case "Month":
                    DateTime tempMonth = DateTime.Now.AddMonths(-7);
                    break;
            }
            return result;
        }
    }
}
