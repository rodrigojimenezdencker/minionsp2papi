using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIMinionsP2P.Models;

namespace APIMinionsP2P.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeudorsController : ControllerBase
    {
        private readonly APIMinionsP2PContext _context;

        public DeudorsController(APIMinionsP2PContext context)
        {
            _context = context;
        }

        // GET: api/Deudors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deudor>>> GetDeudor()
        {
            return await _context.Deudor.ToListAsync();
        }

        // GET: api/Deudors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deudor>> GetDeudor(int id)
        {
            var deudor = await _context.Deudor.FindAsync(id);

            if (deudor == null)
            {
                return NotFound();
            }

            return deudor;
        }

        // PUT: api/Deudors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeudor(int id, Deudor deudor)
        {
            if (id != deudor.Id)
            {
                return BadRequest();
            }

            _context.Entry(deudor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeudorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Deudors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Deudor>> PostDeudor(Deudor deudor)
        {
            _context.Deudor.Add(deudor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeudor", new { id = deudor.Id }, deudor);
        }

        // DELETE: api/Deudors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Deudor>> DeleteDeudor(int id)
        {
            var deudor = await _context.Deudor.FindAsync(id);
            if (deudor == null)
            {
                return NotFound();
            }

            _context.Deudor.Remove(deudor);
            await _context.SaveChangesAsync();

            return deudor;
        }

        private bool DeudorExists(int id)
        {
            return _context.Deudor.Any(e => e.Id == id);
        }
    }
}
