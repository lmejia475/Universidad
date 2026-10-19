using ColegioSolution.Models;
using Microsoft.EntityFrameworkCore;
namespace ColegioSolution.Contexts
{
    public class DbContextApp : DbContext
    {
        public DbSet<ColegioSolution.Models.Docente> Docente { get; set; } = default!;
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }
        public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
