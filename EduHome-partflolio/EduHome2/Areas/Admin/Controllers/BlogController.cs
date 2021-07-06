using ClosedXML.Excel;
using EduHome2.Data;
using EduHome2.Models;
using EduHome2.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHome2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "Blog";
            List<Blog> blogs = _context.Blog.Include(v=>v.BlogCategory).ToList();

            List<VmBlogToExcel> data = blogs.Select(b => new VmBlogToExcel{
             Title = b.Title, 
             Category = b.BlogCategory.Name,
             Date = b.Date.ToString("dd.MM.yyyy"),
             Description = b.Description
            }).ToList();

            TempData["Blogs"] = JsonConvert.SerializeObject(data);
            return View(blogs);
        }
        public IActionResult Create()
        {
            ViewBag.BlogCategory = _context.BlogCategory.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                if (!(model.ImageFile.ContentType== "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("" ,"You can only upload jpeg,png,gif");
                    ViewBag.BlogCategory = _context.BlogCategory.ToList();
                    return View(model);
                }
                if (model.ImageFile.Length> 3145728)
                {
                    ModelState.AddModelError("", "You can only max 2 mb size image");
                    ViewBag.BlogCategory = _context.BlogCategory.ToList();
                    return View(model);
                }

                string fileName = Guid.NewGuid() + "~"+DateTime.Now.ToString("ddMMyyyyHHmmss")+ "~"+ model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images",fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                model.image = fileName;
                _context.Blog.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.BlogCategory = _context.BlogCategory.ToList();
            return View(model);
        }

        public IActionResult ExportExcel()
        {
            string blogs = (string)TempData["Blogs"];
            List<VmBlogToExcel> data = JsonConvert.DeserializeObject<List<VmBlogToExcel>>(blogs);

            var workbook = new XLWorkbook();
            var ws = workbook.AddWorksheet("Blog List");

            ws.Row(1).Height = 4;
            ws.Row(2).Height = 22;
            ws.Column("A").Width= 0.5;
            ws.Column("B").Width= 8;
            ws.Column("C").Width= 50;
            ws.Column("D").Width= 30;
            ws.Column("E").Width= 25;
            ws.Column("F").Width= 20;

            ws.Range("B2:F2").Merge();
            ws.Cell("B2").Value = "Blog List";
            ws.Cell("B2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("B2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("B2").Style.Font.SetBold();
            ws.Cell("B2").Style.Font.FontSize = 14;


            


            for (int i = 0; i < data.Count; i++)
            {

                ws.Cell("B"+(i+4)).Value = i+1;
                ws.Cell("B" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("B" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("B" + (i + 4)).Style.Font.FontSize = 12;
                ws.Cell("B" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell("C" + (i + 4)).Value = data[i].Title;
                ws.Cell("C" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("C" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("C" + (i + 4)).Style.Font.FontSize = 12;
                ws.Cell("C" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell("D" + (i + 4)).Value = data[i].Description;
                ws.Cell("D" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("D" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("D" + (i + 4)).Style.Font.FontSize = 12;
                ws.Cell("D" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("E" + (i + 4)).Value = data[i].Date;
                ws.Cell("E" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("E" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("E" + (i + 4)).Style.Font.FontSize = 12;
                ws.Cell("E" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("F" + (i + 4)).Value = data[i].Category;
                ws.Cell("F" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell("F" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("F" + (i + 4)).Style.Font.FontSize = 12;
                ws.Cell("F" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.speadsheetml.sheet", "Blog_List.xlsx");
            }

        }
    }

   
}
