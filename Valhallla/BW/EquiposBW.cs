using Abstracciones.BC;
using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.Entidades;

namespace BW
{
    public class EquipoBW : IEquipoBW
    {
        private IEquipoDA _equipoDA;
        private IPokemonDA _pokemonDA;
        private IEquipoBC _equipoBC;
        private IEntrenadorDA _entrenadorDA;

        public EquipoBW(IEquipoDA equiposDA, IEquipoBC equipoBC, IPokemonDA pokemonDA, IEntrenadorDA entrenadorDA)
        {
            _equipoDA = equiposDA;
            _equipoBC = equipoBC;
            _pokemonDA = pokemonDA;
            _entrenadorDA = entrenadorDA;
        }

        public async Task<int> GenerarEquipos()
        {
            var entrenadores = await _entrenadorDA.Obtener();
            var pokemon = await _pokemonDA.ObtenerPokemon();
            return await _equipoBC.GenerarEquipos(entrenadores, pokemon);
        }

        public async Task<IEnumerable<Abstracciones.Modelos.Equipo>> ObtenerEquipos()
        {
            return await _equipoDA.ObtenerEquipos();
        }
    }
}