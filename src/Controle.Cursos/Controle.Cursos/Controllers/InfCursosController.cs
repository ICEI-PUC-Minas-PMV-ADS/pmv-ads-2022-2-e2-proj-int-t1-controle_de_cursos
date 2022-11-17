using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle.Cursos.Models;
using Controle.Cursos.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controle.Cursos.Controllers
{
   
    public class InfCursosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InfCursosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InfCursos
        public async Task<IActionResult> Index()
        {
            return View(await _context.InfCursos.ToListAsync());
        }

        // GET: InfCursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infCurso = await _context.InfCursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infCurso == null)
            {
                return NotFound();
            }

            return View(infCurso);
        }

        // GET: InfCurso/Details/5
        public async Task<IActionResult> Relatorio(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infCurso = await _context.InfCursos
                .Include(t => t.Consumos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (infCurso == null)
            {
                return NotFound();
            }

            return View(infCurso);
        }



        // GET: InfCursos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CargaHoraria")] InfCursos infCurso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infCurso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infCurso);
        }

        // GET: InfCursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infCurso = await _context.InfCursos.FindAsync(id);
            if (infCurso == null)
            {
                return NotFound();
            }
            return View(infCurso);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Placa")] InfCursos infCurso)
        {
            if (id != infCurso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infCurso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!infCursoExists(infCurso.Id))
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
            return View(infCurso);
        }

        // GET: InfCursoS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.InfCursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veiculo = await _context.InfCursos.FindAsync(id);
            _context.InfCursos.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfCursosExists(int id)
        {
            return _context.InfCursos.Any(e => e.Id == id);
        }
    }