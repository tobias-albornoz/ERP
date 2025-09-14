using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPGranjita.Shared.Models
{
    public class VentaDiaria
    {
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal TotalBalanzas { get; set; }
        [StringLength(255)]
        public string? Comentarios { get; set; }

        public List<DetalleVentaDiaria>? DetallesVentaDiaria { get; set; }
        public List<TicketError>? TicketsError { get; set; }
        public List<Senia>? Senias { get; set; }
        public List<CierreDeBalanza>? CierresDeBalanza { get; set; }


        public decimal CalcularSaldoFinal()
        {
            // Suma el saldo inicial más el total de los detalles de venta diaria
            var totalDetalles = (DetallesVentaDiaria ?? new List<DetalleVentaDiaria>()).Sum(d => d.Monto);
            return SaldoInicial + totalDetalles;
        }

        public decimal CalcularTotalBalanzas()
        {
            // Suma el total vendido en balanzas y descuenta los tickets con error
            var totalBalanzas = (CierresDeBalanza ?? new List<CierreDeBalanza>()).Sum(c => c.TotalVendido);
            var totalTicketsError = (TicketsError ?? new List<TicketError>()).Sum(t => t.Monto);
            return totalBalanzas - totalTicketsError;
        }

        // Calcula la diferencia entre el saldo final y el total de ventas
        public decimal CalcularDiferencia()
        {
            var saldoFinal = CalcularSaldoFinal();
            var totalVentas = CalcularTotalBalanzas();
            return saldoFinal - totalVentas;
        }
    }
}   