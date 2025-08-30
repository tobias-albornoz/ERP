using ERPGranjita.Shared.Models;
using ERPGranjita.API.Repositories;

namespace ERPGranjita.API.Services
{
    public class ProductosService
    {
        private readonly ProductosRepository _repo;
        public ProductosService(ProductosRepository repo) => _repo = repo;

        public Task<List<Producto>> ListarProductosAsync() => _repo.GetAllAsync();

        public Task<Producto> RegistrarProductoAsync(Producto producto)
        {
            // Aqu� puedes agregar reglas de negocio si es necesario
            return _repo.AddAsync(producto);
        }
    }
}