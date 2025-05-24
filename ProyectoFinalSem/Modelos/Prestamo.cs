using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalSem.Data
{
    public class Prestamo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un libro")]
        public int LibroId { get; set; }
        public Libro? Libro { get; set; }

        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre del usuario no debe exceder los 100 caracteres")]
        public string? NombreUsuario { get; set; }

        [Required(ErrorMessage = "Debe especificar la fecha del préstamo")]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe especificar la fecha de devolución")]
        public DateTime FechaDevolucion { get; set; }

        public bool Devuelto { get; set; } = false;
    }
}