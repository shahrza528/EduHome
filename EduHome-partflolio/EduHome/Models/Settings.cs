using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Phone_navbar { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(200)]
        public string Company_Email { get; set; }
        [MaxLength(200)]
        public string Company_Site { get; set; }
        [MaxLength(2000)]
        public string Company_Description { get; set; }
    }
}
