using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERPGranjita.Shared.Models
{
    public class CierreDeBalanza
    {
        public int Id { get; set; }

        [Required]
        public int VentaDiariaId { get; set; }

        [JsonIgnore]
        public VentaDiaria? VentaDiaria { get; set; }

        [Required]
        public int PuntoVentaId { get; set; }

        public PuntoDeVenta? PuntoDeVenta { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int CantidadTickets { get; set; }

        [Required]
        public decimal TotalVendido { get; set; }

        [StringLength(255)]
        public string? Comentarios { get; set; }
    }
}