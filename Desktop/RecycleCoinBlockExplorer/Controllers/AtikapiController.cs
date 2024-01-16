using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecycleCoinBlockExplorer.Data;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtikapiController : ControllerBase
    {
        private readonly DataContext _context;

        public AtikapiController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Atik>>> AddAtik(Atik atik)
        {
            _context.Atiklar.Add(atik);
            await _context.SaveChangesAsync();

            return Ok(await _context.Atiklar.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Atik>>> GetAllAtik()
        {
            return Ok(await _context.Atiklar.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Atik>> GetAtik(int id)
        {
            var atik = await _context.Atiklar.FindAsync(id);
            if(atik == null) 
            {
                return BadRequest("Atik bulunamadi");
            }
            return Ok(atik);
        }
    }
}
