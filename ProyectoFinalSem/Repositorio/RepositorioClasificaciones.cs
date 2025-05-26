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

        // Obtener todas las clasificaciones
        public async Task<List<Clasificacion>> GetAll()
        {
            return await _context.Clasificaciones.ToListAsync();
        }

        // Obtener una clasificación por ID
        public async Task<Clasificacion?> Get(int id)
        {
            return await _context.Clasificaciones.FindAsync(id);
        }

        // Agregar una nueva clasificación
        public async Task<Clasificacion?> Add(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
            return clasificacion;
        }

        // Actualizar una clasificación existente
        public async Task Update(int id, Clasificacion clasificacion)
        {
            var existente = await _context.Clasificaciones.FindAsync(id);
            if (existente != null)
            {
                existente.Nombre = clasificacion.Nombre;
                await _context.SaveChangesAsync();
            }
        }

        // Eliminar una clasificación
        public async Task Delete(int id)
        {
            var clasificacion = await _context.Clasificaciones.FindAsync(id);
            if (clasificacion != null)
            {
                _context.Clasificaciones.Remove(clasificacion);
                await _context.SaveChangesAsync();
            }
        }

        // Método adicional si necesitas compatibilidad con GetClasificaciones()
        public async Task<List<Clasificacion>> GetClasificaciones()
        {
            return await GetAll();
        }
    }
}
