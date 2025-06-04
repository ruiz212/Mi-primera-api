using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstuidiantConApi.Models
{
    public class Estudinate
    {

        public int IdEstudiante { get; set; }

        public string Nombre { get; set; }


        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
    }
}
