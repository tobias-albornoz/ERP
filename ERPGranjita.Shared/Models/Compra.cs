using System;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
        public decimal Total { get; set; }
        public string? Comentarios { get; set; }
        public List<DetalleDeCompra> Detalles { get; set; } = new();
        public List<PagoCompra> Pagos { get; set; } = new();
    }
}