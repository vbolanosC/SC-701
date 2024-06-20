using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class PokemonBW : IPokemonBW
    {
        private IPokemonDA _pokemonDA;

        public PokemonBW(IPokemonDA pokemonDA)
        {
            _pokemonDA = pokemonDA;
        }

        public async Task<IEnumerable<Equipo>> Obtener()
        {
            var equiposPokemon = await _pokemonDA.Obtener();
            return equiposPokemon;
        }

        public Task<Equipo> Obtener(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
