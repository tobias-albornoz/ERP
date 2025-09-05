using ERPGranjita.Shared.Models;
using ERPGranjita.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComprasController : ControllerBase
    {
        private readonly ComprasService _service;

        public ComprasController(ComprasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Compra>>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Compra>> Get(int id)
        {
            var compra = await _service.GetByIdAsync(id);
            if (compra == null) return NotFound();
            return compra;
        }

        [HttpPost]
        public async Task<ActionResult<Compra>> Post(Compra compra)
        {
            var created = await _service.AddAsync(compra);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }
    }
}