using ERPGranjita.Shared.Models;
using ERPGranjita.API.Repositories;

namespace ERPGranjita.API.Services
{
    public class RubroService
    {
        private readonly RubroRepository _repository;

        public RubroService(RubroRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Rubro>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Rubro?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task<Rubro> AddAsync(Rubro rubro) => _repository.AddAsync(rubro);
        public Task<bool> UpdateAsync(Rubro rubro) => _repository.UpdateAsync(rubro);
        public Task<bool> DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}