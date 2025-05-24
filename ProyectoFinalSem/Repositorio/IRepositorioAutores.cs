using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public interface IRepositorioAutores
    {
        // Lista de autores
        Task<List<Autor>> GetAll();
        // Obtener un autor por ID
        Task<Autor?> Get(int id);
        // Agregar autor
        Task<Autor?> Add(Autor autor);
        // Actualizar autor
        Task Update(int id, Autor autor);
        // Eliminar autor
        Task Delete(int id);
    }
}

