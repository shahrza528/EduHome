﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CoursesDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
