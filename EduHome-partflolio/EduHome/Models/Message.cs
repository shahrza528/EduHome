using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public string Subject { get; set; }
        [MaxLength(4000)]
        public string Text { get; set; }
    }
}
