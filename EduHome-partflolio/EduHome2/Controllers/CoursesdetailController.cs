﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Controllers
{
    public class CoursesdetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}