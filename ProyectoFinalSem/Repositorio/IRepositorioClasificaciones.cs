using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public interface IRepositorioClasificaciones
    {
        // Obtener todas las clasificaciones
        Task<List<Clasificacion>> GetAll();

        // Obtener una clasificación por ID
        Task<Clasificacion?> Get(int id);

        // Agregar una nueva clasificación
        Task<Clasificacion?> Add(Clasificacion clasificacion);

        // Actualizar una clasificación existente
        Task Update(int id, Clasificacion clasificacion);

        // Eliminar una clasificación
        Task Delete(int id);

        // Método que ya tenías (puedes usarlo como alias de GetAll si quieres)
        Task<List<Clasificacion>> GetClasificaciones();
    }
}
