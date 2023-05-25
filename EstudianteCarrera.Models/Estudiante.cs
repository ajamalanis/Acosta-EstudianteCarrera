using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteCarrera.Models
{
    public class Estudiante
    {

        [Key]
        public int EstudianteuId { get; set; } //pk
        [Required]
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Cedula { get; set; }

        //relacion
        
        public Carrera? Carrera { get; set; } //fk
        public int CarreraId { get; set; } //pk


    }
}
