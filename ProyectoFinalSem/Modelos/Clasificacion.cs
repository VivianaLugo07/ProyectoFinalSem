using System.ComponentModel.DataAnnotations;
namespace ProyectoFinalSem.Modelos
{
    public class Clasificacion
    {
        public int Id {  get; set; }    
        public string? Nombre { get; set; }
        //coleccion de autores para hacer una propiedad de navegacion
        virtual public ICollection<Autor>? Autores { get; set; }
    }
}
