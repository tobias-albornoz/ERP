using ERPGranjita.Shared.Models;
using ERPGranjita.API.Repositories;

namespace ERPGranjita.API.Services
{
    public class UnidadMedidaService
    {
        private readonly UnidadMedidaRepository _repository;

        public UnidadMedidaService(UnidadMedidaRepository repository)
        {
            _repository = repository;
        }

        public Task<List<UnidadMedida>> GetAllAsync() => _repository.GetAllAsync();
        public Task<UnidadMedida?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
    }
}