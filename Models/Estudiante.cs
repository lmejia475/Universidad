using System.ComponentModel.DataAnnotations;

namespace ColegioSolution.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        
        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [StringLength(50)]
        public string Nombres { get; set; }
        
        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo Direccion es obligatorio.")]
        [StringLength(100)]
        public string Direccion { get; set; }
    }
}
