﻿using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.SG
{
    public interface IPokemonSG
    {
        Task<Pokemon> Obtener(int numero);
    }
}
