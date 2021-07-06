using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [Column(TypeName ="ntext")]
        public string Decription { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        public DateTime StratTime { get; set; }
        public DateTime Duration { get; set; }
        public DateTime ClassDuration { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        [ForeignKey("Language")]
        public int LanuageId { get; set; }
        public Lanuage Language { get; set; }

        [ForeignKey("Assesments")]
        public int AssesmentsId { get; set; }
        public Assesments Assesments { get; set; }
        public int Price { get; set; }
        public List<Student> Students { get; set; }
        public List<CourseCategory> CourseCategoryies { get; set; }
        public List<CoursetoTag> CoursetoTags { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
