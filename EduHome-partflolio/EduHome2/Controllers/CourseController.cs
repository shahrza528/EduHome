using EduHome2.Data;
using EduHome2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController( AppDbContext context)
        {
         
            _context = context;
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome();
            if (Request.Cookies["Cart"]!=null)
            {
                List<string> cookieData = Request.Cookies["Cart"].Split("-").ToList();
                model.Cart = _context.Course.Where(c => cookieData.Any(d => d == c.Id.ToString())).ToList();
            }

            model.Sliders = _context.Slider.ToList();
            model.Courses = _context.Course.Include(s => s.Skill)
                                            .Include(l => l.Language)
                                            .Include(a => a.Assesments)
                                            .Include(c => c.Comments)
                                            .Include(t => t.CoursetoTags)
                                            .Include(k => k.CourseCategoryies).ToList();
            return View(model);
        }

        public JsonResult AddToCard(int courseId)
        {
            string responsTypeBase;
            var oldData = Request.Cookies["Cart"];
            if (oldData !=null)
            {
                List<string> oldDataArr = oldData.Split("-").ToList();
               bool isExist= oldDataArr.Any(d => d == courseId.ToString());
                responsTypeBase = "not-added";
                if (!isExist)
                {
                    var newdata = oldData + "-" + courseId;
                    Response.Cookies.Append("Cart", newdata);
                    responsTypeBase = "added";
                }

            }
            else
            {
                Response.Cookies.Append("Cart", courseId.ToString());
                responsTypeBase = "Created";
            }
            

            return Json(new { statusCode=200,responsType= responsTypeBase});
        }
    }
}
