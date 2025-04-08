
using System.ComponentModel.DataAnnotations;

namespace Actividad6.Components.Data
{
    public class Persona
    {

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es valido")]
        public string? Correo { get; set; }
        [Range(15, 120, ErrorMessage = "La edad debe ser entre 15 y 120")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El genero es obligatorio")]
        public string? Genero { get; set; }
    }
}