using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100)]
        public string? UnidadMedida { get; set; }

        public string? Descripcion { get; set; }
    }
}