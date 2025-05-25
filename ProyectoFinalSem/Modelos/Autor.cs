using ProyectoFinalSem.Modelos;
using System.ComponentModel.DataAnnotations;

public class Autor
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Nombre { get; set; }

    [Required]
    [StringLength(100)]
    public string? Nacionalidad { get; set; }

    // Esto ya no va aquí:
    public string? Libro { get; set; }

    
}
