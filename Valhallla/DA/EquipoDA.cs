using Abstracciones.Modelos;
using Abstracciones.DA;
using Microsoft.Data.SqlClient;
using Dapper;
using Helpers;
using Abstracciones.Entidades;

namespace DA
{
    public class EquipoDA : IEquipoDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public EquipoDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }

        public async Task<Guid> Agregar(Abstracciones.Entidades.Equipo equipo)
        {
            string query = @"[AgregarEquipo]";
            await _sqlConnection.ExecuteAsync(query, new { IdEquipo = equipo.IdEquipo, IDEntrenador = equipo.IdEntrenador, Nombre = equipo.Nombre });
            return equipo.IdEquipo;
        }

        public async Task AgregarPokemonxEquipo(Abstracciones.Entidades.PokemonxEquipo pokemonxEquipo)
        {
            string query = @"[AgregarPokemonEquipo]";
            await _sqlConnection.ExecuteAsync(query, new { IdEquipo = pokemonxEquipo.IdEquipo, Idpokemon = pokemonxEquipo.IdPokemon });
        }

        public async Task<IEnumerable<Abstracciones.Modelos.Equipo>> ObtenerEquipos()
        {
            string query = @"[ListarEquipos]";
            var consulta = await _sqlConnection.QueryAsync<Abstracciones.Modelos.Equipo>(query);
            return consulta;

        }



        #region Convertidores

        private IEnumerable<Abstracciones.Modelos.Pokemon> ConvertirListaPokemonDBAModelo(IEnumerable<Abstracciones.Entidades.Pokemon> pokemon)
        {
            var resultadoConversion = Convertidor.ConvertirLista<Abstracciones.Entidades.Pokemon, Abstracciones.Modelos.Pokemon>(pokemon);
            return resultadoConversion;
        }

        #endregion
    }
}