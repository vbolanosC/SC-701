using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Validaciones
{
    public class ValidarMayusculas : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Entrenador entrenador = (Entrenador)validationContext.ObjectInstance;
            if (entrenador.Nombre.ToUpper() != entrenador.Nombre)
                return new ValidationResult("El nombre debe estar en mayúscula");

            return ValidationResult.Success;
        }
    }
}
