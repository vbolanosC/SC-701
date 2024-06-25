
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.BC;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase, IEquipoController
    {
        private IEquipoBW _equipoBW;

        public EquipoController(IEquipoBW equipoBW)
        {
            _equipoBW = equipoBW;
        }
        [HttpPost]
        [Route("Generar")]
        public async Task<IActionResult> GenerarEquipos()
        {
            int resultado = await _equipoBW.GenerarEquipos();
            if (resultado == 0)
                return NoContent();
            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerEquipos()
        {
            return Ok(await _equipoBW.ObtenerEquipos());
        }
    }
}
