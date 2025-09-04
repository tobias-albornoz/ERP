using ERPGranjita.API.Data;
using ERPGranjita.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Repositories
{
    public class ProveedoresRepository
    {
        private readonly CarniceriaDbContext _context;
        public ProveedoresRepository(CarniceriaDbContext context) => _context = context;

        public async Task<List<Proveedor>> GetAllAsync() =>
            await _context.Proveedores.Include(p => p.Rubro).ToListAsync();

        public async Task<Proveedor?> GetByIdAsync(int id) =>
            await _context.Proveedores.Include(p => p.Compras).ThenInclude(c => c.Producto)
                .FirstOrDefaultAsync(p => p.Id == id);

        public async Task AddAsync(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            await _context.SaveChangesAsync();
        }
    }
}