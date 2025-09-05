using ERPGranjita.Shared.Models;
using ERPGranjita.API.Repositories;

namespace ERPGranjita.API.Services
{
    public class ComprasService
    {
        private readonly ComprasRepository _repository;

        public ComprasService(ComprasRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Compra>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Compra?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task<Compra> AddAsync(Compra compra)
        { 
            // Calcula el total y los subtotales
            foreach (var detalle in compra.Detalles)
            {
                detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;
            }
            compra.Total = compra.Detalles.Sum(d => d.Subtotal);

            return _repository.AddAsync(compra);
        } 
    }
}