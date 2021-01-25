using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SitePessoalMasMelhor.Data;
using SitePessoalMasMelhor.Models;

namespace SitePessoalMasMelhor.Controllers
{
    public class ExpProfissionalController : Controller
    {
        private readonly SitePessoalBdContext _context;

        public ExpProfissionalController(SitePessoalBdContext context)
        {
            _context = context;
        }

        // GET: ExpProfissional
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExpProfissional.ToListAsync());
        }

        // GET: ExpProfissional/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expProfissional = await _context.ExpProfissional
                .FirstOrDefaultAsync(m => m.ExpProfissionalId == id);
            if (expProfissional == null)
            {
                return NotFound();
            }

            return View(expProfissional);
        }

        // GET: ExpProfissional/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpProfissional/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExpProfissionalId,Empresa,Funcao,Detalhes,Data")] ExpProfissional expProfissional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expProfissional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expProfissional);
        }

        // GET: ExpProfissional/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expProfissional = await _context.ExpProfissional.FindAsync(id);
            if (expProfissional == null)
            {
                return NotFound();
            }
            return View(expProfissional);
        }

        // POST: ExpProfissional/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExpProfissionalId,Empresa,Funcao,Detalhes,Data")] ExpProfissional expProfissional)
        {
            if (id != expProfissional.ExpProfissionalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expProfissional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpProfissionalExists(expProfissional.ExpProfissionalId))
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
            return View(expProfissional);
        }

        // GET: ExpProfissional/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expProfissional = await _context.ExpProfissional
                .FirstOrDefaultAsync(m => m.ExpProfissionalId == id);
            if (expProfissional == null)
            {
                return NotFound();
            }

            return View(expProfissional);
        }

        // POST: ExpProfissional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expProfissional = await _context.ExpProfissional.FindAsync(id);
            _context.ExpProfissional.Remove(expProfissional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpProfissionalExists(int id)
        {
            return _context.ExpProfissional.Any(e => e.ExpProfissionalId == id);
        }
    }
}
