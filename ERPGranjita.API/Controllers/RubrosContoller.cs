using ERPGranjita.API.Services;
using ERPGranjita.API.Services;
using ERPGranjita.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RubrosController : ControllerBase
    {
        private readonly RubroService _service;

        public RubrosController(RubroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Rubro>>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rubro>> Get(int id)
        {
            var rubro = await _service.GetByIdAsync(id);
            if (rubro == null) return NotFound();
            return rubro;
        }

        [HttpPost]
        public async Task<ActionResult<Rubro>> Post(Rubro rubro)
        {
            var created = await _service.AddAsync(rubro);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Rubro rubro)
        {
            if (id != rubro.Id) return BadRequest();
            var updated = await _service.UpdateAsync(rubro);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}