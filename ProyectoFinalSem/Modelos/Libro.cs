using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalSem.Data
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título del libro es obligatorio")]
        [StringLength(200, ErrorMessage = "El título no debe exceder los 200 caracteres")]
        public string? Titulo { get; set; }

        [Range(1000, 3000, ErrorMessage = "El año de publicación debe ser entre 1000 y 3000")]
        public int AnioPublicacion { get; set; }

        public bool Disponible { get; set; } = true;

        [Required(ErrorMessage = "Debe seleccionar un autor")]
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }

        public ICollection<Prestamo>? Prestamos { get; set; }
    }
}
