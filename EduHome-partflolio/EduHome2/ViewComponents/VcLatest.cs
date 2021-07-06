using EduHome2.Data;
using EduHome2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.ViewComponents
{
    public class VcLatest:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcLatest(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            VmBlog model = new VmBlog();
            model.Blogs = _context.Blog.Take(3).ToList();
            return View(model);
        }
    }
}
