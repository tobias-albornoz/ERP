using Microsoft.EntityFrameworkCore;
using ERPGranjita.Shared.Models;

namespace ERPGranjita.API.Data
{
    public class CarniceriaDbContext : DbContext
    {
        public CarniceriaDbContext(DbContextOptions<CarniceriaDbContext> options) : base(options) { }
        public DbSet<Venta> Ventas { get; set; }
      /*  public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Gasto> Gastos { get; set; }*/
    }
}