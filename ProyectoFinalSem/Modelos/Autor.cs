using ProyectoFinalSem.Modelos;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalSem.Modelos
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo Nacionalidad es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nacionalidad no puede tener más de 100 caracteres.")]
        public string? Nacionalidad { get; set; }

        [Required(ErrorMessage = "El campo Libro es obligatorio.")]
        public string? Libro { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El campo Clasificación es obligatorio.")]
        public int ClasificacionId { get; set; }

        // Propiedad de navegación para EF
        public virtual Clasificacion? Clasificacion { get; set; }

        public virtual ICollection<Editorial>? Editoriales { get; set; }
    }
}
