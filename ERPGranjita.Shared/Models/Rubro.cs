using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class Rubro
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Descripcion { get; set; }
    }
}