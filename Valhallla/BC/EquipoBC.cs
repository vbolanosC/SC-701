using Abstracciones.BC;
using Abstracciones.DA;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    public class EquipoBC : IEquipoBC
    {
        private IEquipoDA _equipoDA;

        public EquipoBC(IEquipoDA equipoDA)
        {
            _equipoDA = equipoDA;
        }

        public async Task<int> GenerarEquipos(IEnumerable<Entrenador> entrenadores, IEnumerable<Pokemon> pokemons)
        {
            int indice = 0;
            foreach (var entrenador in entrenadores)
            {
                Guid equipo = await CrearEquipo(entrenador);
                var pokemonAAgregar = pokemons.Skip(indice).Take(6).ToList();
                foreach (var pokemon in pokemonAAgregar)
                {
                    await AsignarPokemon(equipo, new Abstracciones.Entidades.PokemonxEquipo() { IdPokemon = pokemon.Id, IdEquipo = equipo });
                }
                indice += 6;
            }
            return entrenadores.Count();
        }

        private async Task AsignarPokemon(Guid equipo, Abstracciones.Entidades.PokemonxEquipo pokemonxEquipo)
        {
            await _equipoDA.AgregarPokemonxEquipo(pokemonxEquipo);
        }

        private async Task<Guid> CrearEquipo(Entrenador entrenador)
        {
            return await _equipoDA.Agregar(new Abstracciones.Entidades.Equipo() { IdEquipo = Guid.NewGuid(), IdEntrenador = entrenador.Id, Nombre = $"Equipo de {entrenador.Nombre}" });
        }
    }
}
