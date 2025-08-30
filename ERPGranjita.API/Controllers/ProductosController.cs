using Microsoft.AspNetCore.Mvc;
using ERPGranjita.Shared.Models;
using ERPGranjita.API.Services;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosService _service;
        public ProductosController(ProductosService service) => _service = service;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get() =>
            Ok(await _service.ListarProductosAsync());

        [HttpPost]
        public async Task<ActionResult<Producto>> Post(Producto producto)
        {
            var creado = await _service.RegistrarProductoAsync(producto);
            return CreatedAtAction(nameof(Get), new { id = creado.Id }, creado);
        }
    }
}