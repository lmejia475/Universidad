
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioSolution.Models
{
    public class Asignacion
    {
        [Key]
        public int AsignacionId { get; set; }

        [Required]
        public int EstudianteId { get; set; }

        [ForeignKey(nameof(EstudianteId))]
        public Estudiante? Estudiante { get; set; }

        [Required]
        public int CursoId { get; set; }

        [ForeignKey(nameof(CursoId))]
        public Curso? Curso { get; set; }

        [Required]
        public int DocenteId { get; set; }

        [ForeignKey(nameof(DocenteId))]
        public Docente? Docente { get; set; }

    }
}
