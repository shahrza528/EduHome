using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class Tags
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<CoursetoTag> CoursetoTags { get; set; }
        public List<BlogtoTag> BlogtoTag { get; set; }
    }
}
