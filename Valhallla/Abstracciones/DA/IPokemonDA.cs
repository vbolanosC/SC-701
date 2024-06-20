using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IPokemonDA
    {
        public Task<IEnumerable<Equipo>> Obtener();

        public Task<IEnumerable<Pokemon>> Obtener(Guid Id);
    }
}
