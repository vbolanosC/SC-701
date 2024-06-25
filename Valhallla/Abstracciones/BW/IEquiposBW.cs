using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BW
{
    public interface IEquipoBW
    {
        public Task<IEnumerable<Equipo>> ObtenerEquipos();
        public Task<int> GenerarEquipos();
    }
}
