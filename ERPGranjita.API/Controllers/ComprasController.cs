using ERPGranjita.API.Services;
using ERPGranjita.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComprasController : ControllerBase
    {
        private readonly ComprasService _service;
        public ComprasController(ComprasService service) => _service = service;

        [HttpPost]
        public async Task<ActionResult> Post(CompraProducto compra)
        {
            await _service.AddAsync(compra);
            return CreatedAtAction(nameof(Post), new { id = compra.Id }, compra);
        }
    }
}