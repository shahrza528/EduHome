using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(2000)]
        public string Name { get; set; }
        public List<Blog> Blog { get; set; }
    }
}
