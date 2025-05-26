using ProyectoFinalSem.Modelos;

namespace ProyectoFinalSem.Repositorio
{
    public interface IRepositorioClasificaciones
    {
        //leer las clasificaciones
        Task<List<Clasificacion>> GetClasificaciones();
    }
}