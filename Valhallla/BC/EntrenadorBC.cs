using Abstracciones.BC;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    public class EntrenadorBC : IEntrenadorBC
    {
        public Entrenador DarFormato(Entrenador entrenador)
        {
            entrenador.Nombre = NombreMayuscula(entrenador.Nombre);
            return entrenador;
        }

        private string NombreMayuscula(string nombre)
        {
            return nombre.ToUpper();
        }
    }
}
