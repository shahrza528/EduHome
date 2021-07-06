using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class BlogtoTag
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Blog")]
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("Tags")]
        public int TagsID { get; set; }
        public Tags Tags { get; set; }
    }
}
