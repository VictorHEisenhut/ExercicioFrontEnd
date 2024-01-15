﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Data;
using TestAPI.Entities;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocaisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LocaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Locais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Local>>> GetLocais()
        {
          if (_context.Locais == null)
          {
              return NotFound();
          }
            return await _context.Locais.ToListAsync();
        }

        // GET: api/Locais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Local>> GetLocal(int id)
        {
          if (_context.Locais == null)
          {
              return NotFound();
          }
            var local = await _context.Locais.FindAsync(id);

            if (local == null)
            {
                return NotFound();
            }

            return local;
        }

        // PUT: api/Locais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocal(int id, Local local)
        {
            if (id != local.Id)
            {
                return BadRequest();
            }

            _context.Entry(local).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalExists(id))
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

        // POST: api/Locais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Local>> PostLocal(Local local)
        {
          if (_context.Locais == null)
          {
              return Problem("Entity set 'AppDbContext.Locais'  is null.");
          }
            _context.Locais.Add(local);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocal", new { id = local.Id }, local);
        }

        // DELETE: api/Locais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocal(int id)
        {
            if (_context.Locais == null)
            {
                return NotFound();
            }
            var local = await _context.Locais.FindAsync(id);
            if (local == null)
            {
                return NotFound();
            }

            _context.Locais.Remove(local);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocalExists(int id)
        {
            return (_context.Locais?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
