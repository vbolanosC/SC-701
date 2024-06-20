using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Pokemon
    {
        public Guid Id { get; set; }

        public int Numero {  get; set; }

        public int Nivel { get; set; }

        public string? Nombre{ get; set; }

        public string? Tipo { get; set; }

        public string? Sprite { get; set; }

        public string? crie { get; set; }
    }
}
