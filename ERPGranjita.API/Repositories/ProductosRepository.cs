using ERPGranjita.Shared.Models;
using ERPGranjita.API.Data;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Repositories
{
    public class ProductosRepository
    {
        private readonly CarniceriaDbContext _context;
        public ProductosRepository(CarniceriaDbContext context) => _context = context;

        public Task<List<Producto>> GetAllAsync() =>
            _context.Productos.OrderBy(p => p.Nombre).ToListAsync();

        public async Task<Producto> AddAsync(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }
    }
}