using EduHome2.Data;
using EduHome2.Models;
using EduHome2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlog model = new VmBlog();
            model.Blogs= _context.Blog.ToList();

            return View(model);
        }
        public IActionResult Detail()
        {
            VmBlog model = new VmBlog();
            model.CourseCategory = _context.CourseCategory.ToList();
            model.Blogs = _context.Blog.Take(3).ToList();
            return View(model);
        }

        public IActionResult LeftSidebar()
        {
            VmBlog model = new VmBlog();
            model.Blogs = _context.Blog.ToList();
            model.CourseCategory = _context.CourseCategory.ToList();
            model.Blogs = _context.Blog.Take(3).ToList();
            return View(model);
        }
    }
}
