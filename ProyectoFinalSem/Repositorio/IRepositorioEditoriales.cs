using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public interface IRepositorioEditoriales
    {
        Task<List<Editorial>> GetAll();
        Task<Editorial?> Get(int id);
        Task<Editorial?> Add(Editorial editorial);
        Task Update(int id, Editorial editorial);
        Task<List<Editorial>> GetEditoriales(); 
    }
}
