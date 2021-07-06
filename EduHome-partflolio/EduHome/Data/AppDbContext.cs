using EduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Data
{
    public class AppDbContext:DbContext
    {
        internal object settings;

        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Assesment> Assesments { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Course_Categories> Course_Categories{ get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<Slider> Sliders{ get; set; }
        public DbSet<Social> Socials{ get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Video> Videos{ get; set; }
    }
}
