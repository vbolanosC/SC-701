using Abstracciones.BC;
using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.Modelos;
using Abstracciones.SG;

namespace BW
{
    public class PokemonBW : IPokemonBW
    {

        private IPokemonDA _pokemonDA;
        private IEntrenadorDA _entrenadorDA;
        private IPokemonSG _pokemonSG;
        private IPokemonBC _pokemonBC;

        public PokemonBW(IPokemonDA pokemonDA, IPokemonSG pokemonSG, IPokemonBC pokemonBC, IEntrenadorDA entrenadorDA)
        {
            _pokemonDA = pokemonDA;
            _pokemonSG = pokemonSG;
            _pokemonBC = pokemonBC;
            _entrenadorDA = entrenadorDA;
        }

        public async Task<int> GenerarPokemon()
        {
            int cantidadEntrenadores = await _entrenadorDA.ObtenerCantidad();
            if (cantidadEntrenadores == 0)
                return 0;
            return await _pokemonBC.GenerarPokemon(cantidadEntrenadores);
        }

        public async Task<IEnumerable<Pokemon>> ObtenerPokemonXEquipos(Guid Id)
        {
            var pokemonBD = await _pokemonDA.ObtenerPokemonXEquipo(Id);
            List<Pokemon> EquipoPokemon = new List<Pokemon>();
            foreach (var pokemon in pokemonBD)
            {
                var pokemonAPI = await _pokemonSG.Obtener(pokemon.Numero);
                //Implementar lógica para completar el modelo Pokemon con la información del API
                pokemon.Sprite = pokemonAPI.Sprite;
                pokemon.crie = pokemonAPI.crie;
                pokemon.Nombre = pokemonAPI.Nombre;
                pokemon.Tipo = pokemonAPI.Tipo;
                EquipoPokemon.Add(pokemon);
            }

            return EquipoPokemon;
        }
    }
}
