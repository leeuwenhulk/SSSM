using Microsoft.EntityFrameworkCore;
using SSSM.Common.Models;

namespace SSSM.Common.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MajorModel> Majors { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<StudentCourseMapModel> StudentCourseMaps { get; set; }
        public DbSet<SchoolGradeModel> schoolGrades { get; set; }
        public DbSet<SchoolClassModel> schoolClasses { get; set; }
    }
}