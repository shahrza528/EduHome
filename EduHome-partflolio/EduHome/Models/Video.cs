using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Video
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(250)]
        public string URL { get; set; }

    }
}
