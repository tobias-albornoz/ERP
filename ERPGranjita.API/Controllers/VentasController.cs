using Microsoft.AspNetCore.Mvc;
using ERPGranjita.Shared.Models;
using ERPGranjita.API.Data;
using Microsoft.EntityFrameworkCore;

namespace ERPGranjita.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly CarniceriaDbContext _context;
        public VentasController(CarniceriaDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> Get() =>
            await _context.Ventas.OrderByDescending(x => x.Fecha).ToListAsync();

        [HttpPost]
        public async Task<ActionResult<Venta>> Post(Venta venta)
        {
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = venta.Id }, venta);
        }
    }
}