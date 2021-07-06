﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(250),Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName ="ntext"), Required]
        public string Description { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }

    }
}
