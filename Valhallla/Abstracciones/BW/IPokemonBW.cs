using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BW
{
    public interface IPokemonBW
    {
        public Task<IEnumerable<Equipo>> Obtener();

        public Task<Equipo> Obtener(Guid Id);
    }
}
