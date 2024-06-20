using Abstracciones.DA;
using Abstracciones.Modelos;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class PokemonDA : IPokemonDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public PokemonDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;

            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }

        public async Task<IEnumerable<Equipo>> Obtener()
        {
            string query = @"[ListarEquipos]";
            var consulta = await _sqlConnection.QueryAsync<Abstracciones.Modelos.Equipo>(query);

            return consulta;
        }


        public Task<IEnumerable<Pokemon>> Obtener(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
