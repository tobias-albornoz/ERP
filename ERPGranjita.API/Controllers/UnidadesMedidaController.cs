using ERPGranjita.Shared.Models;
using ERPGranjita.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadesMedidaController : ControllerBase
    {
        private readonly UnidadMedidaService _service;

        public UnidadesMedidaController(UnidadMedidaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<UnidadMedida>>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadMedida>> Get(int id)
        {
            var unidad = await _service.GetByIdAsync(id);
            if (unidad == null) return NotFound();
            return unidad;
        }
    }
}