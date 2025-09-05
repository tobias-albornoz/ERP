using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public int UnidadMedidaId { get; set; }

        public int RubroId { get; set; }

        public Rubro? Rubro { get; set; }
        public UnidadMedida? UnidadMedida { get; set; }
    }
}