using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Main_Image { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string toApply { get; set; }
        public string Certification { get; set; }
        public string Starts { get; set; }
        public string Duration { get; set; }
        [MaxLength(10)]
        public string Class_Duration { get; set; }

        List<Course_Categories> Course_Categories { get; set; }

        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [ForeignKey("Assesments")]
        public int Assesment { get; set; }
        public Assesment Assesments { get; set; }


    }
}
