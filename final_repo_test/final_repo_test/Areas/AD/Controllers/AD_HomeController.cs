﻿using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.AD.Controllers
{
    [Area(areaName: "AD")]
    public class AD_HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
