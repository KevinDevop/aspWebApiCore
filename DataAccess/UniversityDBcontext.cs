using aspWebApiCore.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace aspWebApiCore.DataAccess
{
    public class UniversityDBcontext : DbContext
    {
        public UniversityDBcontext(DbContextOptions<UniversityDBcontext> options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
    }
}
