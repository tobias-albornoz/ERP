using System;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class DetalleDeCompra
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public Compra? Compra { get; set; }
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}