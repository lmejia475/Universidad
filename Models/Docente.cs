using System.ComponentModel.DataAnnotations;

namespace ColegioSolution.Models
{
    public class Docente
    {
        [Key]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        [StringLength(50)]
        public string Apellidos { get; set; }
    }
}
