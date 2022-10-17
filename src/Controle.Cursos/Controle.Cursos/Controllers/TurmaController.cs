using Controle.Cursos.Models;
using Controle.Cursos.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Cursos.Controllers
{
    public class TurmaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TurmaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Turmas.ToListAsync());
        }
        
        public async Task<IActionResult> DetailsAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turma = await _context.Turmas
                .FirstOrDefaultAsync(c => c.Id == id);

            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        public ActionResult Create()
        {
            var cursos = _context.Cursos.ToList();

            if (cursos != null)
            {
                ViewBag.Cursos = cursos;
            }

            var solicitacoes = _context.Solicitacoes.ToList();

            if (solicitacoes != null)
            {
                ViewBag.Solicitacoes = solicitacoes;
            }

            return View();
        }

        public ActionResult SolicitacaoPartial(
            [Bind("Id")] int cursoId)
        {
            var cursos = _context.Cursos.ToList();

            if (cursos != null)
            {
                ViewBag.Cursos = cursos;
            }

            var solicitacoes = _context.Solicitacoes
                .Select(s => s)
                .Where(s => s.CursoId == cursoId)
                .AsEnumerable();

            if (solicitacoes != null)
            {
                ViewBag.Solicitacoes = solicitacoes;
            }

            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id, AlunoId, CursoId")] Turma turma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(turma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(turma);
        }

        public async Task<IActionResult> EditAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turma = await _context.Turmas.FindAsync(id);

            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(int id, 
            [Bind("Id, AlunoId, CursoId")] Turma turma)
        {
            if (id != turma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurmaExiste(turma.Id))
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

            return View(turma);
        }

        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turma = await _context.Turmas
                .FirstOrDefaultAsync(c => c.Id == id);

            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(int id, IFormCollection collection)
        {
            var turma = await _context.Turmas.FindAsync(id);
            _context.Turmas.Remove(turma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurmaExiste(int id)
        {
            return _context.Turmas.Any(e => e.Id == id);
        }
    }
}