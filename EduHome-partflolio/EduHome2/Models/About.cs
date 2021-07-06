﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [Column(TypeName ="ntext")]
        public string Description { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }

    }
}
