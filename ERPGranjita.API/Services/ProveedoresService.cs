using ERPGranjita.Shared.Models;

namespace ERPGranjita.API.Services
{
    public class ProveedoresService
    {
        private readonly Repositories.ProveedoresRepository _repo;
        public ProveedoresService(Repositories.ProveedoresRepository repo) => _repo = repo;

        public Task<List<Proveedor>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Proveedor?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task AddAsync(Proveedor proveedor) => _repo.AddAsync(proveedor);
    }
}