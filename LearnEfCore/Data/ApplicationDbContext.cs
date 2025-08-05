using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnEfCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<StudentAdditionalDetail> StudentAdditionalDetails { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentTeacher>(builder =>
            {
                builder.HasKey(studentTeacher => new
                {
                    studentTeacher.StudentId,
                    studentTeacher.TeacherId
                });
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
