using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalSem.Modelos
{
    public class Editorial
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo del nombre de la editorial es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string? Nombre { get; set; }
        virtual public ICollection<Autor>? Autores { get; set; }
    }
}
