using System;
using Abstracciones.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BC
{
    public interface IPokemonBC
    {
        Task<int> GenerarPokemon(int cantidadEntrenadores);
    }
}
