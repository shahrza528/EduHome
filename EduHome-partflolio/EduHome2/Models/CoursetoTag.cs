using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class CoursetoTag
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Tags")]
        public int TagsId { get; set; }
        public Tags Tags { get; set; }
    }
}
