using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2000)]
        public string MessageText { get; set; }
        [ForeignKey("ParentComment")]
        public int? CommentId { get; set; }
        public Comment ParentComment { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
