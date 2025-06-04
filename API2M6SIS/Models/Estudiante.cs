using System.ComponentModel.DataAnnotations;

namespace API2M6SIS.Models
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        [Required, MaxLength(25)]
        public string Nombre { get; set; }
        [Required, MaxLength(25)]

        public string Apellido { get; set; }
        [Range(18, 60)]

        public int Edad { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }
}
