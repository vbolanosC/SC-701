using Abstracciones.BC;
using Abstracciones.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    public class PokemonBC : IPokemonBC
    {
        private IPokemonDA _pokemonDA;

        public PokemonBC(IPokemonDA pokemonDA)
        {
            _pokemonDA = pokemonDA;
        }

        public async Task<int> GenerarPokemon(int cantidadEntrenadores)
        {
            if (cantidadEntrenadores == 0)
                return 0;
            for (int i = 1; i <= (cantidadEntrenadores * 6); i++)
            {
                Random random = new Random();
                int numero = random.Next(1, 251);
                int nivel = random.Next(1, 100);
                await _pokemonDA.Agregar(new Abstracciones.Entidades.Pokemon { Id = Guid.NewGuid(), Numero = numero, Nivel = nivel });
            }
            return cantidadEntrenadores * 6;
        }
    }
}