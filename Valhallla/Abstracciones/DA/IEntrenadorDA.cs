using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IEntrenadorDA
    {
        public Task<IEnumerable<Entrenador>> Obtener();
        public Task<Entrenador> Obtener(Guid Id);
        public Task<int> ObtenerCantidad();
        public Task<Guid> AgregarAsync(Entrenador entrenador);
        public Task<Guid> Editar(Entrenador entrenador);
        public Task<Guid> Eliminar(Guid Id);
    }

}
