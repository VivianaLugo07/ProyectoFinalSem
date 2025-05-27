using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public interface IRepositorioEditoriales
    {
        // Obtener todas las editoriales
        Task<List<Editorial>> GetAll();

        // Obtener una editorial por ID
        Task<Editorial?> Get(int id);

        // Agregar una nueva editorial
        Task<Editorial?> Add(Editorial editorial);

        // Actualizar una editorial existente
        Task Update(int id, Editorial editorial);

        // Eliminar una editorial
        Task Delete(int id);

        // Método adicional para obtener todas las editoriales (alias de GetAll)
        Task<List<Editorial>> GetEditoriales();
    }
}
