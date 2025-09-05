using Microsoft.EntityFrameworkCore;
using ERPGranjita.Shared.Models;

namespace ERPGranjita.API.Data
{
    public class CarniceriaDbContext : DbContext
    {
        public CarniceriaDbContext(DbContextOptions<CarniceriaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Rubro> Rubro { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<DetalleDeCompra> DetalleDeCompra { get; set; }
        public DbSet<PagoCompra> PagoCompra { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            // Relación Compra - Proveedor (muchas compras para un proveedor)
            modelBuilder.Entity<Compra>()
                .HasOne(cp => cp.Proveedor)
                .WithMany(p => p.Compras)
                .HasForeignKey(cp => cp.ProveedorId);

            // Relación Proveedor - Rubro
            modelBuilder.Entity<Proveedor>()
                .HasOne(p => p.Rubro)
                .WithMany()
                .HasForeignKey(p => p.RubroId);

            // Relación Producto - UnidadMedida
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.UnidadMedida)
                .WithMany()
                .HasForeignKey(p => p.UnidadMedidaId);

            // Relación Producto - Rubro
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Rubro)
                .WithMany()
                .HasForeignKey(p => p.RubroId);

            // Relación DetalleDeCompra - Compra (muchos detalles para una compra)
            modelBuilder.Entity<DetalleDeCompra>()
                .HasOne(d => d.Compra)
                .WithMany(c => c.Detalles)
                .HasForeignKey(d => d.CompraId);

            // Relación DetalleDeCompra - Producto (muchos detalles para un producto)
            modelBuilder.Entity<DetalleDeCompra>()
                .HasOne(d => d.Producto)
                .WithMany()
                .HasForeignKey(d => d.ProductoId);

            // Relación PagoCompra - Compra
            modelBuilder.Entity<PagoCompra>()
                .HasOne(p => p.Compra)
                .WithMany(c => c.Pagos)
                .HasForeignKey(p => p.CompraId);

            // Relación PagoCompra - FormaPago
            modelBuilder.Entity<PagoCompra>()
                .HasOne(p => p.FormaPago)
                .WithMany()
                .HasForeignKey(p => p.FormaPagoId);

        }*/
    }
}