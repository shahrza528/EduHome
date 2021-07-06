using EduHome2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EduHome2.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<About> About { get; set; }
        public DbSet<Assesments> Assesments { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<CoursetoTag> CoursetoTag { get; set; }
        public DbSet<Lanuage> Lanuage { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MorganSlider> MorganSlider { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Social> Social { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogCategory> BlogCategory { get; set; }
        public DbSet<BlogtoTag> BlogtoTag { get; set; }
        public DbSet<CustomUser> CustomUser { get; set; }
    }
}
