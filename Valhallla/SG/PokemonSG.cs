using Abstracciones.Modelos;
using Abstracciones.SG;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SG
{
    public class PokemonSG: IPokemonSG
    {
        public IConfiguration _configuration;

        public PokemonSG(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Pokemon> Obtener(int numero)
        {
            string endPoint = _configuration.GetSection("APIEndPoints").Get<List<ApiEndPoint>>().Where(e => e.Nombre == "ObtenerPokemon").First().Valor;

            var cliente = new HttpClient();

            var solicitud = new HttpRequestMessage(HttpMethod.Get, string.Format(endPoint, numero));

            var respuesta = await cliente.SendAsync(solicitud);

            respuesta.EnsureSuccessStatusCode();

            var resultado = await respuesta.Content.ReadAsStringAsync();

            var pokemonAPI = JsonConvert.DeserializeObject<PokemonAPI>(resultado);

            return new Pokemon() { Numero = pokemonAPI.id, Nombre = pokemonAPI.name, Tipo = pokemonAPI.types[0].type.name, crie = pokemonAPI.cries.latest, Sprite = pokemonAPI.sprites.other.officialartwork.front_default };
        }
    }
}
