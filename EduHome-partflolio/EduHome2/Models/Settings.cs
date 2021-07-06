using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo1 { get; set; }
        [MaxLength(250)]
        public string Logo2 { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone1 { get; set; }
        [MaxLength(20)]
        public string Phone2 { get; set; }
        [MaxLength(20)]
        public string Phone3 { get; set; }
        [MaxLength(500)]
        public string Adress { get; set; }
        [MaxLength(50)]
        public string Link { get; set; }
        [MaxLength(250)]
        public string Video { get; set; }
        [MaxLength(250)]
        public string VideoImage { get; set; }
        [MaxLength(50)]
        public string Map { get; set; }
    }
}
