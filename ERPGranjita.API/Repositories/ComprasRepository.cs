using ERPGranjita.API.Data;
using ERPGranjita.Shared.Models;

namespace ERPGranjita.API.Repositories
{
    public class ComprasRepository
    {
        private readonly CarniceriaDbContext _context;
        public ComprasRepository(CarniceriaDbContext context) => _context = context;

        public async Task AddAsync(CompraProducto compra)
        {
            _context.ComprasProductos.Add(compra);
            await _context.SaveChangesAsync();
        }
    }
}