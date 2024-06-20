using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Equipo
    {
        public Guid Id { get; set; }
        public Guid IdEntrenador { get; set; }
        public string? NombreEquipo { get; set; }
        public string? NombreEntrenador { get; set; }
    }
}
