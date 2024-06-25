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
        public Task<IEnumerable<Pokemon>> ObtenerPokemonXEquipo(Guid Id);
        public Task<IEnumerable<Pokemon>> ObtenerPokemon();
        public Task Agregar(Entidades.Pokemon pokemon);
    }
}
