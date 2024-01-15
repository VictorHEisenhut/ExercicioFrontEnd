using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Data;
using TestAPI.Data.Dtos;
using TestAPI.Entities;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompromissosController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CompromissosController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Compromissos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compromisso>>> GetCompromissos()
        {
          if (_context.Compromissos == null)
          {
              return NotFound();
          }
            return await _context.Compromissos.ToListAsync();
        }

        // GET: api/Compromissos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compromisso>> GetCompromisso(int id)
        {
          if (_context.Compromissos == null)
          {
              return NotFound();
          }
            var compromisso = await _context.Compromissos.FindAsync(id);

            if (compromisso == null)
            {
                return NotFound();
            }

            return compromisso;
        }

        // PUT: api/Compromissos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompromisso(int id, Compromisso compromisso)
        {
            if (id != compromisso.Id)
            {
                return BadRequest();
            }

            _context.Entry(compromisso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompromissoExists(id))
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

        // POST: api/Compromissos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Compromisso>> PostCompromisso(CreateCompromissoDto compromissoDto)
        {
          if (_context.Compromissos == null)
          {
              return Problem("Entity set 'AppDbContext.Compromissos'  is null.");
          }

            var compromisso = _mapper.Map<Compromisso>(compromissoDto);
            compromisso.Local = _context.Locais.FirstOrDefault(l => l.Id == compromissoDto.LocalId);
            compromisso.Contato = _context.Contatos.FirstOrDefault(c => c.Id == compromissoDto.ContatoId);

            _context.Compromissos.Add(compromisso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompromisso", new { id = compromisso.Id }, compromisso);
        }

        // DELETE: api/Compromissos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompromisso(int id)
        {
            if (_context.Compromissos == null)
            {
                return NotFound();
            }
            var compromisso = await _context.Compromissos.FindAsync(id);
            if (compromisso == null)
            {
                return NotFound();
            }

            _context.Compromissos.Remove(compromisso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompromissoExists(int id)
        {
            return (_context.Compromissos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
