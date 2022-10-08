using Microsoft.EntityFrameworkCore;

namespace Controle.Cursos.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
    }
}
