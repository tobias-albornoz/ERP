using ERPGranjita.API.Data;
using ERPGranjita.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Repositories
{
    public class ComprasRepository
    {
        private readonly CarniceriaDbContext _context;

        public ComprasRepository(CarniceriaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Compra>> GetAllAsync()
        {
            return await _context.Compra
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                    .ThenInclude(d => d.Producto)
                .Include(c => c.Pagos)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Compra?> GetByIdAsync(int id)
        {   
            return await _context.Compra
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                    .ThenInclude(d => d.Producto)
                .Include(c => c.Pagos)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Compra> AddAsync(Compra compra)
        {
            _context.Compra.Add(compra);
            await _context.SaveChangesAsync();
            return compra;
        }
    }
}