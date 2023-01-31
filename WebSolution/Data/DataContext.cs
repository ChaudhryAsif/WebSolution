using Microsoft.EntityFrameworkCore;
using WebSolution.Models;

namespace WebSolution.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> Enrollments { get; set; }
    }
}
