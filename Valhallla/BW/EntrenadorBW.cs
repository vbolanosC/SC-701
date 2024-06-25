using Abstracciones.BC;
using Abstracciones.BW;
using Abstracciones.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class EntrenadorBW : IEntrenadorBW
    {
        private IEntrenadorDA _entrenadorDA;
        private IEntrenadorBC _entrenadorBC;

        public EntrenadorBW(IEntrenadorDA entrenadorDA, IEntrenadorBC entrenadorBC)
        {
            _entrenadorDA = entrenadorDA;
            _entrenadorBC = entrenadorBC;
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Entrenador entrenador)
        {
            var entrenadorConFormato = _entrenadorBC.DarFormato(entrenador);
            return await _entrenadorDA.AgregarAsync(entrenadorConFormato);
        }

        public async Task<Guid> Editar(Abstracciones.Modelos.Entrenador entrenador)
        {
            return await _entrenadorDA.Editar(entrenador);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _entrenadorDA.Eliminar(Id);
        }

        public Task<IEnumerable<Abstracciones.Modelos.Entrenador>> Obtener()
        {
            return _entrenadorDA.Obtener();
        }

        public Task<Abstracciones.Modelos.Entrenador> Obtener(Guid Id)
        {
            return _entrenadorDA.Obtener(Id);
        }

        public Task<int> ObtenerCantidad()
        {
            return _entrenadorDA.ObtenerCantidad();
        }
    }
}