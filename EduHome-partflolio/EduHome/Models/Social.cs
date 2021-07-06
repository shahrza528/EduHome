using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Social
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string Url { get; set; }
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }

    }
}
