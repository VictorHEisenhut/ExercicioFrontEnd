using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AulaEntity.Models;

namespace AulaEntity.Controllers
{
    public class CompromissoController : Controller
    {
        private readonly AppDbContext _context;

        public CompromissoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Compromisso
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Compromisso.Include(c => c.Contato).Include(c => c.Local);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Compromisso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Compromisso == null)
            {
                return NotFound();
            }

            var compromisso = await _context.Compromisso
                .Include(c => c.Contato)
                .Include(c => c.Local)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compromisso == null)
            {
                return NotFound();
            }

            return View(compromisso);
        }

        // GET: Compromisso/Create
        public IActionResult Create()
        {
            ViewBag.ContatoId = new SelectList(_context.Contato, "Id", "Nome");
            ViewBag.LocalId = new SelectList(_context.Local, "Id", "Nome");
            return View();
        }

        // POST: Compromisso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,ContatoId,LocalId")] Compromisso compromisso)
        {
            compromisso.Contato = _context.Contato.FirstOrDefault(c => c.Id == compromisso.ContatoId);
            compromisso.Local = _context.Local.FirstOrDefault(c => c.Id == compromisso.LocalId);
            
            //if (ModelState.IsValid)
            {
                _context.Add(compromisso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            /*ViewBag.ContatoId = new SelectList(_context.Contato, "Id", "Nome", compromisso.ContatoId);
            ViewBag.LocalId = new SelectList(_context.Local, "Id", "Nome", compromisso.LocalId);*/
            return View(compromisso);
        }

        // GET: Compromisso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Compromisso == null)
            {
                return NotFound();
            }

            var compromisso = await _context.Compromisso.FindAsync(id);
            if (compromisso == null)
            {
                return NotFound();
            }
            ViewData["ContatoId"] = new SelectList(_context.Contato, "Id", "Id", compromisso.ContatoId);
            ViewData["LocalId"] = new SelectList(_context.Local, "Id", "Id", compromisso.LocalId);
            return View(compromisso);
        }

        // POST: Compromisso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,ContatoId,LocalId")] Compromisso compromisso)
        {
            if (id != compromisso.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compromisso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompromissoExists(compromisso.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContatoId"] = new SelectList(_context.Contato, "Id", "Id", compromisso.ContatoId);
            ViewData["LocalId"] = new SelectList(_context.Local, "Id", "Id", compromisso.LocalId);
            return View(compromisso);
        }

        // GET: Compromisso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Compromisso == null)
            {
                return NotFound();
            }

            var compromisso = await _context.Compromisso
                .Include(c => c.Contato)
                .Include(c => c.Local)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compromisso == null)
            {
                return NotFound();
            }

            return View(compromisso);
        }

        // POST: Compromisso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Compromisso == null)
            {
                return Problem("Entity set 'AppDbContext.Compromisso'  is null.");
            }
            var compromisso = await _context.Compromisso.FindAsync(id);
            if (compromisso != null)
            {
                _context.Compromisso.Remove(compromisso);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompromissoExists(int id)
        {
          return (_context.Compromisso?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
