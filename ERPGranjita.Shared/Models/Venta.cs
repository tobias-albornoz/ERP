using System;

namespace ERPGranjita.Shared.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroBalanza { get; set; }
        public decimal TotalVenta { get; set; }
        public int Tickets { get; set; }
    }
}