using EduHome2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.ViewModel
{
    public class VmBlog
    {
        public List<Blog> Blogs { get; set; }
        public List<CourseCategory> CourseCategory { get; set; }
        public List<Course> Course { get; set; }
    }
}
