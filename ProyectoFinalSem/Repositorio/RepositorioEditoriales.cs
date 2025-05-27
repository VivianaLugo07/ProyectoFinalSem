using Microsoft.EntityFrameworkCore;
using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public class RepositorioEditoriales : IRepositorioEditoriales
    {
        private readonly BibliotecaDbContext _context;

        public RepositorioEditoriales(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Editorial>> GetAll()
        {
            return await _context.Editoriales.ToListAsync();
        }

        public async Task<Editorial?> Get(int id)
        {
            return await _context.Editoriales
                .Include(e => e.Autores) 
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Editorial?> Add(Editorial editorial)
        {
            await _context.Editoriales.AddAsync(editorial);
            await _context.SaveChangesAsync();
            return editorial;
        }

        public async Task Update(int id, Editorial editorial)
        {
            var existente = await _context.Editoriales.FindAsync(id);
            if (existente != null)
            {
                existente.Nombre = editorial.Nombre;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var editorial = await _context.Editoriales.FindAsync(id);
            if (editorial != null)
            {
                _context.Editoriales.Remove(editorial);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Editorial>> GetEditoriales()
        {
            return await GetAll();
        }
    }
}
