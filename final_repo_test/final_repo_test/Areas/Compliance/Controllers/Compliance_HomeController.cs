using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using Microsoft.Data.SqlClient;
using System.Globalization;
using Microsoft.AspNetCore.Antiforgery;

namespace final_repo_test.Areas.Compliance.Controllers
{
    [Area("Compliance")]
    public class Compliance_HomeController : Controller
    {
        private readonly ChickenDbContext _context;

        public Compliance_HomeController(ChickenDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    

        //[HttpPost, ActionName("Index")]
        //[ValidateAntiForgeryToken]
        //public IActionResult Index()
        //public async Task<IActionResult> Index1()
        public IActionResult Index1()
        {
            var configurationBuilder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration config = configurationBuilder.Build();
            string connectionString = config["ConnectionStrings:DefaultConnection"];

            // var users = new List<Ads>(); // 創建一個 ViewModel 的列表來儲存查詢結果
           var addatas = new List<AdData>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //  await connection.OpenAsync();
                //using (var command = new SqlCommand("SELECT DATENAME(QUARTER, Ad_StartTime) AS Ad_season, COUNT(Ad_ID) AS Ad_count FROM Ads WHERE YEAR(Ad_StartTime) = '2022' GROUP BY DATENAME(QUARTER, Ad_StartTime)", connection))
                using (var command = new SqlCommand("SELECT CASE WHEN DATENAME(QUARTER, Ad_StartTime) = '1' THEN '第一季' WHEN DATENAME(QUARTER, Ad_StartTime) = '2' THEN '第二季' WHEN DATENAME(QUARTER, Ad_StartTime) = '3' THEN '第三季' WHEN DATENAME(QUARTER, Ad_StartTime) = '4' THEN '第四季' END AS Ad_season, COUNT(Ad_ID) AS Ad_count FROM Ads WHERE YEAR(Ad_StartTime) = '2022' GROUP BY DATENAME(QUARTER, Ad_StartTime)", connection))
                {
                    using (var reader = command.ExecuteReader())
                    //using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                               // while (await reader.ReadAsync())
                                        
                                {
                                AdData aData = new AdData();
                                aData.Ad_count = (int)reader["Ad_count"];
                                aData.Ad_season = (string)reader["Ad_season"];
                                addatas.Add(aData);

                                //    var Ad_count = (int)reader["Ad_count"];
                                //    var Ad_season = (string)reader["Ad_season"];

                                //    // 將讀取到的每一行資料加入到 ViewModel 列表中
                                //    users.Add(new Ads
                                //    {
                                //        //Ad_StartTime = quarterStart
                                //        //Ad_ID = Ad_count,
                                //        //Ad_StartTime = new DateTime(int.Parse((string)reader["Ad_season"]), 1, 1).AddMonths((int.Parse((string)reader["Ad_season"]) - 1) * 3),
                                //        Ad_ID = Ad_count,
                                //        Ad_StartTime = new DateTime(int.Parse((string)reader["Ad_season"]), 1, 1).AddMonths((int.Parse((string)reader["Ad_season"]) - 1) * 3),
                                //    });
                            }
                    }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }
                    }
                }
                connection.Close();
            }
            return Json(addatas);
        }
    }

public class AdData
    {
        public string Ad_season { get; set; }
        public int Ad_count { get; set; }
    }
}
