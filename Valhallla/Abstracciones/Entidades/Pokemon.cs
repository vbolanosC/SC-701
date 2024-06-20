using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Entidades
{
    public class Pokemon
    {
        public Guid Id { get; set; }

        public int Numero {  get; set; }

        public int Nivel { get; set; }
    }
}
