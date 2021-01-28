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
    public class SobreMimController : Controller
    {
        private readonly SitePessoalBdContext _context;

        public SobreMimController(SitePessoalBdContext context)
        {
            _context = context;
        }

        // GET: SobreMim
        public async Task<IActionResult> Index()
        {
            return View(await _context.SobreMim.ToListAsync());
        }

        // GET: SobreMim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sobreMim = await _context.SobreMim
                .FirstOrDefaultAsync(m => m.SobreMimId == id);
            if (sobreMim == null)
            {
                return NotFound();
            }

            return View(sobreMim);
        }

        // GET: SobreMim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SobreMim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SobreMimId,Sobre")] SobreMim sobreMim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sobreMim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sobreMim);
        }

        // GET: SobreMim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sobreMim = await _context.SobreMim.FindAsync(id);
            if (sobreMim == null)
            {
                return NotFound();
            }
            return View(sobreMim);
        }

        // POST: SobreMim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SobreMimId,Sobre")] SobreMim sobreMim)
        {
            if (id != sobreMim.SobreMimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sobreMim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SobreMimExists(sobreMim.SobreMimId))
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
            return View(sobreMim);
        }

        // GET: SobreMim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sobreMim = await _context.SobreMim
                .FirstOrDefaultAsync(m => m.SobreMimId == id);
            if (sobreMim == null)
            {
                return NotFound();
            }

            return View(sobreMim);
        }

        // POST: SobreMim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sobreMim = await _context.SobreMim.FindAsync(id);
            _context.SobreMim.Remove(sobreMim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SobreMimExists(int id)
        {
            return _context.SobreMim.Any(e => e.SobreMimId == id);
        }
    }
}
