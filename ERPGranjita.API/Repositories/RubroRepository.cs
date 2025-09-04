using ERPGranjita.API.Data;
using ERPGranjita.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Repositories
{
    public class RubroRepository
    {
        private readonly CarniceriaDbContext _context;

        public RubroRepository(CarniceriaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Rubro>> GetAllAsync()
        {
            return await _context.Rubro.ToListAsync();
        }

        public async Task<Rubro?> GetByIdAsync(int id)
        {
            return await _context.Rubro.FindAsync(id);
        }

        public async Task<Rubro> AddAsync(Rubro rubro)
        {
            _context.Rubro.Add(rubro);
            await _context.SaveChangesAsync();
            return rubro;
        }

        public async Task<bool> UpdateAsync(Rubro rubro)
        {
            var existing = await _context.Rubro.FindAsync(rubro.Id);
            if (existing == null) return false;
            existing.Nombre = rubro.Nombre;
            existing.Descripcion = rubro.Descripcion;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var rubro = await _context.Rubro.FindAsync(id);
            if (rubro == null) return false;
            _context.Rubro.Remove(rubro);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}