using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class MorganSlider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required (ErrorMessage ="Adi yazmalisan")]
        public string FullName { get; set; }
        [MaxLength(2000)]
        [Required(ErrorMessage = "Text Daxil Etmelisen")]
        public string Description { get; set; }
        [ForeignKey("Position")]
        [Required(ErrorMessage = "Vezifeni qeyd Etmelisen")]
        public int PostionId { get; set; }
        public Position Position { get; set; }
    }
}
