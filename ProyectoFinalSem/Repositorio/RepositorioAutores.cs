using Microsoft.EntityFrameworkCore;
using ProyectoFinalSem.Modelos;
//  acciones para conectarme con la base de datos

namespace ProyectoFinalSem.Repositorio
{
    public class RepositorioAutores : IRepositorioAutores
    {
        private readonly BibliotecaDbContext _context;

        public RepositorioAutores(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task<Autor?> Add(Autor autor)
        {
            await _context.Autores.AddAsync(autor);
            await _context.SaveChangesAsync();
            return autor;
        }

        public async Task Delete(int id)
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor != null)
            {
                _context.Autores.Remove(autor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Autor?> Get(int id)
        {
            // Incluye la Clasificación al obtener un solo autor
            return await _context.Autores
                .Include(a => a.Clasificacion)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Autor>> GetAll()
        {
            // Incluye la Clasificación para cada autor
            return await _context.Autores
                .Include(a => a.Clasificacion)
                .ToListAsync();
        }

        public async Task Update(int id, Autor autor)
        {
            var existente = await _context.Autores.FindAsync(id);
            if (existente != null)
            {
                existente.Nombre = autor.Nombre;
                existente.Nacionalidad = autor.Nacionalidad;
                existente.Libro = autor.Libro;
                existente.ClasificacionId = autor.ClasificacionId; // Asegura actualizar también la clasificación
                await _context.SaveChangesAsync();
            }
        }
    }
}
