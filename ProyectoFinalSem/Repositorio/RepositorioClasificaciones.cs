using Microsoft.EntityFrameworkCore;
using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public class RepositorioClasificaciones : IRepositorioClasificaciones
    {
        private readonly BibliotecaDbContext _context;

        public RepositorioClasificaciones(BibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<List<Clasificacion>> GetClasificaciones()
        {
            return await _context.Clasificaciones.ToListAsync();
        }
    }
}
