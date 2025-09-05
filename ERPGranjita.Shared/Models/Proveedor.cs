using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(50)]
        public string? Telefono { get; set; }

        [StringLength(255)]
        public string? Direccion { get; set; }

        [StringLength(20)]
        public string? CUIT { get; set; }

        public int RubroId { get; set; }
        public Rubro? Rubro { get; set; } // Si tienes navegación

        public List<Compra> Compras { get; set; } = new();
    }
}