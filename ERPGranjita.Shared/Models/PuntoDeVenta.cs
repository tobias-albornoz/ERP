using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class PuntoDeVenta
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(255)]
        public string? Descripcion { get; set; }

    }
}