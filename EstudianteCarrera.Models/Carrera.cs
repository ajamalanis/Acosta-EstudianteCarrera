using System.ComponentModel.DataAnnotations;

namespace EstudianteCarrera.Models
{
    public class Carrera
    {
        [Key]
        public int CarreraId { get; set; } //pk
        public String Nombre { get; set; }
        public int NumEstudiantes { get; set; }
        public int Niveles { get; set; }

        public List<Estudiante>? Estudiantes { get; set; }

    }
}