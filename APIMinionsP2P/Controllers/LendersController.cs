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
    public class LendersController : ControllerBase
    {
        private readonly APIMinionsP2PContext _context;

        public LendersController(APIMinionsP2PContext context)
        {
            _context = context;
        }

        // GET: api/Lenders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lender>>> GetLender()
        {
            return await _context.Lender.ToListAsync();
        }

        // GET: api/Lenders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lender>> GetLender(int id)
        {
            var lender = await _context.Lender.FindAsync(id);

            if (lender == null)
            {
                return NotFound();
            }

            return lender;
        }

        // PUT: api/Lenders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLender(int id, Lender lender)
        {
            if (id != lender.Id)
            {
                return BadRequest();
            }

            _context.Entry(lender).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LenderExists(id))
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

        // POST: api/Lenders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Lender>> PostLender(Lender lender)
        {
            _context.Lender.Add(lender);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLender", new { id = lender.Id }, lender);
        }

        // DELETE: api/Lenders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lender>> DeleteLender(int id)
        {
            var lender = await _context.Lender.FindAsync(id);
            if (lender == null)
            {
                return NotFound();
            }

            _context.Lender.Remove(lender);
            await _context.SaveChangesAsync();

            return lender;
        }

        private bool LenderExists(int id)
        {
            return _context.Lender.Any(e => e.Id == id);
        }
    }
}
