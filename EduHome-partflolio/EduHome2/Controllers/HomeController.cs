using EduHome2.Data;
using EduHome2.Models;
using EduHome2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           
            VmHome model = new VmHome();
            model.Blogs = _context.Blog.Take(3).ToList();
            model.Sliders=_context.Slider.ToList();
            model.MorganSlider = _context.MorganSlider.Include(v=>v.Position).ToList();
            model.Courses = _context.Course.Include(s=>s.Skill)
                                            .Include(l=>l.Language)
                                            .Include(a=>a.Assesments)
                                            .Include(c=>c.Comments)
                                            .Include(t=>t.CoursetoTags)
                                            .Include(k=>k.CourseCategoryies)
                                            .OrderBy(o=>o.Id).Take(3).ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
