using ERPGranjita.Shared.Models;
using ERPGranjita.API.Data;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Repositories
{
    public class VentasRepository
    {
        private readonly CarniceriaDbContext _context;
        public VentasRepository(CarniceriaDbContext context) => _context = context;

        public Task<List<Venta>> GetAllAsync() =>
            _context.Ventas.OrderByDescending(v => v.Fecha).ToListAsync();

        public async Task<Venta> AddAsync(Venta venta)
        {
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();
            return venta;
        }
    }
}