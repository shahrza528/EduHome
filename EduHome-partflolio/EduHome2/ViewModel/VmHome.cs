using EduHome2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.ViewModel
{
    public class VmHome
    {
        public List<Slider> Sliders { get; set; }
        public List<Course> Cart { get; set; }
        public List<Course> Courses { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<MorganSlider> MorganSlider { get; set; }
        public List<Position> Position { get; set; }
    }
}
