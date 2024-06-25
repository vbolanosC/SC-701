using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.API;
using Abstracciones.BW;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase, IPokemonController
    {
        private IPokemonBW _pokemonBW;

        public PokemonController(IPokemonBW pokemonBW)
        {
            _pokemonBW = pokemonBW;
        }
        [HttpPost]
        [Route("Generar")]
        public async Task<IActionResult> GenerarPokemon()
        {
            int resultado = await _pokemonBW.GenerarPokemon();
            if (resultado == 0)
                return NoContent();
            return Ok(resultado);
        }

        [HttpGet("PokemonxEquipo/{Id}")]
        public async Task<IActionResult> ObtenerPokemonxEquipo([FromRoute] Guid Id)
        {
            return Ok(await _pokemonBW.ObtenerPokemonXEquipos(Id));
        }
    }
}