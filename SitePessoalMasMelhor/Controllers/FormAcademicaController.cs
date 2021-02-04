using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SitePessoalMasMelhor.Data;
using SitePessoalMasMelhor.Models;

namespace SitePessoalMasMelhor.Controllers
{
    public class FormAcademicaController : Controller
    {
        private readonly SitePessoalBdContext _context;

        public FormAcademicaController(SitePessoalBdContext context)
        {
            _context = context;
        }

        // GET: FormAcademica
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormAcademica.ToListAsync());
        }

        // GET: FormAcademica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAcademica = await _context.FormAcademica
                .FirstOrDefaultAsync(m => m.FormAcademicaId == id);
            if (formAcademica == null)
            {
                return NotFound();
            }

            return View(formAcademica);
        }

        // GET: FormAcademica/Create
        [Authorize(Roles = "Administrador")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormAcademica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormAcademicaId,Instituição,Nome,Duração,DataDeConclusão")] FormAcademica formAcademica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formAcademica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formAcademica);
        }

        // GET: FormAcademica/Edit/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAcademica = await _context.FormAcademica.FindAsync(id);
            if (formAcademica == null)
            {
                return NotFound();
            }
            return View(formAcademica);
        }

        // POST: FormAcademica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FormAcademicaId,Instituição,Nome,Duração,DataDeConclusão")] FormAcademica formAcademica)
        {
            if (id != formAcademica.FormAcademicaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formAcademica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormAcademicaExists(formAcademica.FormAcademicaId))
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
            return View(formAcademica);
        }

        // GET: FormAcademica/Delete/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAcademica = await _context.FormAcademica
                .FirstOrDefaultAsync(m => m.FormAcademicaId == id);
            if (formAcademica == null)
            {
                return NotFound();
            }

            return View(formAcademica);
        }

        // POST: FormAcademica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formAcademica = await _context.FormAcademica.FindAsync(id);
            _context.FormAcademica.Remove(formAcademica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormAcademicaExists(int id)
        {
            return _context.FormAcademica.Any(e => e.FormAcademicaId == id);
        }
    }
}
