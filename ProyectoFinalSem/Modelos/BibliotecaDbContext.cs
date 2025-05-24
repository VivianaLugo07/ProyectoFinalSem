using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalSem.Modelos
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options) 
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
