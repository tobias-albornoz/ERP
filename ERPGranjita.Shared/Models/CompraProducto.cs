using System;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class CompraProducto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;

        [Required]
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }
    }
}