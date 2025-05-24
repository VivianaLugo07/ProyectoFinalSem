using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalSem.Data
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del autor es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no debe exceder los 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La nacionalidad es obligatoria")]
        [StringLength(100, ErrorMessage = "La nacionalidad no debe exceder los 100 caracteres")]
        public string? Nacionalidad { get; set; }

        public ICollection<Libro>? Libros { get; set; }
    }
}