using Microsoft.EntityFrameworkCore;
using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    // Acciones para conectarme con la base de datos
    public class RepositorioEditoriales(BibliotecaDbContext _context) : IRepositorioEditoriales
    {
        // Obtener todas las editoriales
        public async Task<List<Editorial>> GetAll()
        {
            return await _context.Editoriales.ToListAsync();
        }

        // Obtener una editorial por ID
        public async Task<Editorial?> Get(int id)
        {
            return await _context.Editoriales.FindAsync(id);
        }

        // Agregar una nueva editorial
        public async Task<Editorial?> Add(Editorial editorial)
        {
            await _context.Editoriales.AddAsync(editorial);
            await _context.SaveChangesAsync();
            return editorial;
        }

        // Actualizar una editorial existente
        public async Task Update(int id, Editorial editorial)
        {
            var existente = await _context.Editoriales.FindAsync(id);
            if (existente != null)
            {
                existente.Nombre = editorial.Nombre;
                await _context.SaveChangesAsync();
            }
        }

        // Eliminar una editorial
        public async Task Delete(int id)
        {
            var editorial = await _context.Editoriales.FindAsync(id);
            if (editorial != null)
            {
                _context.Editoriales.Remove(editorial);
                await _context.SaveChangesAsync();
            }
        }

        // Método adicional si necesitas compatibilidad con GetEditoriales()
        public async Task<List<Editorial>> GetEditoriales()
        {
            return await GetAll();
        }
    }
}
