using EduHome2.Data;
using EduHome2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            List<MorganSlider> sliders1 = _context.MorganSlider.ToList();
            int roleCount = sliders1.Count;

            decimal dataPage = 5;
            decimal pageCount =Math.Ceiling(sliders1.Count/dataPage);
            List<MorganSlider> sliders = sliders1.OrderByDescending(b=>b.Id).Skip(Convert.ToInt32((page-1)*dataPage))
                                                                           .Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.Pagerole = roleCount;
            ViewBag.DataPage = dataPage;



            return View(sliders);
        }
        public IActionResult Detail()
        {
            ViewBag.Active = "Dashboard";
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MorganSlider model)
        {
            if (ModelState.IsValid)
            {
                _context.MorganSlider.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);

        }
        public IActionResult Update(int? testId)
        {
            MorganSlider slider1 = _context.MorganSlider.Find(testId);
            return View(slider1);
        }
        [HttpPost]
        public IActionResult Update(MorganSlider model)
        {
            if (ModelState.IsValid)
            {
                _context.MorganSlider.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);

        }
        public IActionResult Delete(int? testId)
        {

            MorganSlider slider1 = _context.MorganSlider.Find(testId);
            _context.MorganSlider.Remove(slider1);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
