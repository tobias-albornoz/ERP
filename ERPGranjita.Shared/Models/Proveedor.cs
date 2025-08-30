using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Contacto { get; set; }

        [StringLength(100)]
        public string? Telefono { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }

        public List<CompraProducto> Compras { get; set; } = new();
    }
}