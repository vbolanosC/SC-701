using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorController : ControllerBase, IEntrenadorAPI
    {
        private IEntrenadorBW _entrenadorBW;

        public EntrenadorController(IEntrenadorBW entrenadorBW)
        {
            _entrenadorBW = entrenadorBW;
        }
        [HttpPost]
        public async Task<IActionResult> AgregarAsync([FromBody] Entrenador entrenador)
        {
            var resultado = await _entrenadorBW.AgregarAsync(entrenador);
            return CreatedAtAction(nameof(Obtener), new { Id = resultado }, entrenador);
        }
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Entrenador entrenador)
        {
            var entrenadorExiste = await _entrenadorBW.Obtener(entrenador.Id);
            if (entrenadorExiste == null)
                return NotFound();
            return Ok(await _entrenadorBW.Editar(entrenador));
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute] Guid Id)
        {
            var entrenadorExiste = await _entrenadorBW.Obtener(Id);
            if (entrenadorExiste == null)
                return NotFound();
            await _entrenadorBW.Eliminar(Id);
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            return Ok(await _entrenadorBW.Obtener());
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            return Ok(await _entrenadorBW.Obtener(Id));
        }
    }
}