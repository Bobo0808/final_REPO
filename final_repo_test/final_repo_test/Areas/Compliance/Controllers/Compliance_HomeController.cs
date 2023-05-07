using final_repo_test.Data;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_repo_test.Models;
using Microsoft.Data.SqlClient;

namespace final_repo_test.Areas.Compliance.Controllers
{
    [Area("Compliance")]
    public class Compliance_HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Compliance_HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var connectionString = "Server=.;Database=ChickenLife;";
            var query = "SELECT expertise, COUNT(expertise) AS count FROM study_qualification GROUP BY expertise";
            var studyQualifications = new List<Models.Employee>();//明天改

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var studyQualification = new Models.Employee//明天改
                        {
                            E_Name = reader.GetString(0),//明天改
                            //E_Title = reader.GetInt32(1)
                        };
                        studyQualifications.Add(studyQualification);
                    }
                }
            }
            return Json(studyQualifications);
            //return View();
        }
    }
}
