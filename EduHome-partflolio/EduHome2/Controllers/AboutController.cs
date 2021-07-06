using EduHome2.Data;
using EduHome2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Controllers
{
    public class AboutController : Controller

    {
        private readonly AppDbContext _Context;

        public AboutController(AppDbContext context)
        {
            _Context = context;
        }

        public AppDbContext Context { get; }

        public IActionResult Index()
        {
           About about= _Context.About.FirstOrDefault();
            return View(about);
        }
    }
}
