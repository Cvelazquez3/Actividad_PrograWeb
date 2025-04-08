using System.ComponentModel.DataAnnotations;

namespace Actividad6.Components.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero positivo")]
        public int NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [MaxLength(200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio")]
        [RegularExpression("Frutas|Verduras|Lácteos", ErrorMessage = "Debe ser Frutas, Verduras o Lácteos")]
        public string? Departamento { get; set; }
    }
}
