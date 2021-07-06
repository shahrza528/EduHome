using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Teacher
    {
        [Key]
        public  int Id { get; set; }
        [MaxLength(250)]
        public string FullName{ get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [ForeignKey("Professionals")]
        public int ProfessionalId { get; set; }
        public Professional Professionals { get; set; }
        List<Social> socials { get; set; }

    }
}
