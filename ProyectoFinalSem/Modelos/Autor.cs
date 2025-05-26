using ProyectoFinalSem.Modelos;
using System.ComponentModel.DataAnnotations;

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
    //propiedad de navegacion para EF
    public int ClasificacionId { get; set; }
    //para ller el contenido
    virtual public Clasificacion? Clasificacion { get; set; }

}
