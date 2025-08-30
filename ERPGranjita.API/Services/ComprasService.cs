using ERPGranjita.API.Repositories;
using ERPGranjita.Shared.Models;

namespace ERPGranjita.API.Services
{
    public class ComprasService
    {
        private readonly ComprasRepository _repo;
        public ComprasService(ComprasRepository repo) => _repo = repo;

        public Task AddAsync(CompraProducto compra) => _repo.AddAsync(compra);
    }
}