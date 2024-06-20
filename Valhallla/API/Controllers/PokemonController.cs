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

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            return Ok(await _pokemonBW.Obtener());
        }

        [HttpGet("{Id}")]
        public Task<IActionResult> Obtener(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
