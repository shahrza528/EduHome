using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Map_Iframe { get; set; }
        [MaxLength(500)]
        public string Adress { get; set; }
        [MaxLength(500)]
        public string Logo { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
    }
}
