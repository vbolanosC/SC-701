using Abstracciones.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class Entrenador
    {
        [Required]
        [RegularExpression(@"^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(4, ErrorMessage = "Debe ser mayor a 4", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]*$")]
        [ValidarMayusculas]
        public string? Nombre { get; set; }
    }
}
