using ERPGranjita.Shared.Models;
using ERPGranjita.API.Repositories;

namespace ERPGranjita.API.Services
{
    public class VentasService
    {
        private readonly VentasRepository _repo;
        public VentasService(VentasRepository repo) => _repo = repo;

        public Task<List<Venta>> ListarVentasAsync() => _repo.GetAllAsync();

        public Task<Venta> RegistrarVentaAsync(Venta venta)
        {
            // Aquí puedes agregar reglas de negocio
            return _repo.AddAsync(venta);
        }
    }
}