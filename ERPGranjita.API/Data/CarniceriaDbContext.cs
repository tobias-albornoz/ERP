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
        public DbSet<CompraProducto> ComprasProductos { get; set; }
        public DbSet<Rubro> Rubro { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompraProducto>()
                .HasOne(cp => cp.Producto)
                .WithMany()
                .HasForeignKey(cp => cp.ProductoId);

            modelBuilder.Entity<CompraProducto>()
                .HasOne(cp => cp.Proveedor)
                .WithMany(p => p.Compras)
                .HasForeignKey(cp => cp.ProveedorId);

            modelBuilder.Entity<Proveedor>()
                .HasOne(p => p.Rubro)
                .WithMany()
                .HasForeignKey(p => p.RubroId);

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.UnidadMedida)
                .WithMany()
                .HasForeignKey(p => p.UnidadMedidaId);

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Rubro)
                .WithMany()
                .HasForeignKey(p => p.RubroId);


        }
    }
}