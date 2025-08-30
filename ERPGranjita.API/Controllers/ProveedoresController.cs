using ERPGranjita.API.Services;
using ERPGranjita.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProveedoresController : ControllerBase
    {
        private readonly ProveedoresService _service;
        public ProveedoresController(ProveedoresService service) => _service = service;

        [HttpGet]
        public async Task<ActionResult<List<Proveedor>>> Get() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Proveedor>> Get(int id)
        {
            var proveedor = await _service.GetByIdAsync(id);
            return proveedor is null ? NotFound() : Ok(proveedor);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proveedor proveedor)
        {
            await _service.AddAsync(proveedor);
            return CreatedAtAction(nameof(Get), new { id = proveedor.Id }, proveedor);
        }
    }
}