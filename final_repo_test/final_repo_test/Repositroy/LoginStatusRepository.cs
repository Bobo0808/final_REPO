﻿using final_repo_test.Data;
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

        public async Task<GetDayViewModel> GetDay(string Chart)
        {
            
            GetDayViewModel result = new GetDayViewModel();
            result.Unit = Chart.ToLower();
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
                        result.Mainy.Add((await _context.LoginStaus.Where(s => s.L_cTime >= DateTime.Now.AddDays(i)&& s.L_cTime < DateTime.Now.AddDays(jtemp)).ToListAsync()).Count);
                        jtemp += 7;
                    }
                    //jtemp = 1;
                    //for (int i = 0; i < result.Headx.Count; i++)
                    //{
                    //    if (jtemp < result.Headx.Count)
                    //    {
                    //        result.Heady.Add((await _context.LoginStaus.Where(s => s.L_cTime.TimeOfDay >= result.Headx[i] && s.L_cTime.TimeOfDay <= result.Headx[jtemp]).ToListAsync()).Count);
                    //    }
                    //    else
                    //    {
                    //        result.Heady.Add((await _context.LoginStaus.Where(s => s.L_cTime.TimeOfDay >= result.Headx[i]).ToListAsync()).Count);
                    //    }
                    //    jtemp++;
                    //}
                    break;
                case "Month":
                    DateTime tempMonth = DateTime.Now.AddMonths(-7);
                    var listMonth = await _context.LoginStaus.Where(s => s.L_cTime > tempMonth).ToListAsync();
                    result.Average = (int)Math.Round(listMonth.Sum(x => (x.L_dcTime.Subtract(x.L_cTime).TotalHours)) / listMonth.Count);
                    result.UserCount = listMonth.GroupBy(x => x.A_ID).Count();
                    for (int i = -6; i <= 0; i ++)
                    {
                        result.Mainx.Add(DateTime.Now.AddMonths(i));
                        result.Mainy.Add((await _context.LoginStaus.Where(s => s.L_cTime.Month == DateTime.Now.AddMonths(i).Month).ToListAsync()).Count);
                    }
                    break;
            }
           
            return result;
        }
    }
}
