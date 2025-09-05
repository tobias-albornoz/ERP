using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPGranjita.Shared.Models
{
    public class PagoCompra
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public Compra? Compra { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPagoId { get; set; }
        public FormaPago? FormaPago { get; set; }
        public decimal Monto { get; set; }
        public string? Comentarios { get; set; }
    }
}
