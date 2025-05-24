using ProyectoFinalSem.Modelos;
namespace ProyectoFinalSem.Repositorio
    //acciones para conectarme con la base de datos
{
    public class RepositorioAutores : IRepositorioAutores
    {
        public Task<Autor> Add(Autor autor)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Autor?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Autor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Autor autor)
        {
            throw new NotImplementedException();
        }
    }
}
