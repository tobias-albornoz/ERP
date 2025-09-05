using ERPGranjita.API.Data;
using ERPGranjita.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Repositories
{
    public class UnidadMedidaRepository
    {
        private readonly CarniceriaDbContext _context;

        public UnidadMedidaRepository(CarniceriaDbContext context)
        {
            _context = context;
        }

        public async Task<List<UnidadMedida>> GetAllAsync()
        {
            return await _context.UnidadMedida.AsNoTracking().ToListAsync();
        }

        public async Task<UnidadMedida?> GetByIdAsync(int id)
        {
            return await _context.UnidadMedida.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}