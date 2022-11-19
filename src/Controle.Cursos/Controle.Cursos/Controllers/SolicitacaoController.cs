using Controle.Cursos.Models;
using Controle.Cursos.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Cursos.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly Models.ApplicationDbContext _context;
        public SolicitacaoController(Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Solicitacoes.ToListAsync());
        }
        
        public async Task<IActionResult> DetailsAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacao = await _context.Solicitacoes
                .FirstOrDefaultAsync(c => c.Id == id);

            if (solicitacao == null)
            {
                return NotFound();
            }

            return View(solicitacao);
        }

        public ActionResult Create()
        {
            var cursos = _context.Cursos.ToList();

            if (cursos != null)
            {
                ViewBag.Cursos = cursos;
            }

            var alunos = _context.Alunos.ToList();

            if (alunos != null)
            {
                ViewBag.Alunos = alunos;
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id, AlunoId, CursoId")] Solicitacao solicitacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(solicitacao);
        }

        public async Task<IActionResult> EditAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacao = await _context.Solicitacoes.FindAsync(id);

            if (solicitacao == null)
            {
                return NotFound();
            }

            return View(solicitacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(int id, 
            [Bind("Id, AlunoId, CursoId")] Solicitacao solicitacao)
        {
            if (id != solicitacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (SolicitacaoExiste(solicitacao.Id))
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

            return View(solicitacao);
        }

        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacao = await _context.Solicitacoes
                .FirstOrDefaultAsync(c => c.Id == id);

            if (solicitacao == null)
            {
                return NotFound();
            }

            return View(solicitacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelarAsync(int id, IFormCollection collection) {
            var solicitacao = await _context.Solicitacoes.FindAsync(id);

            solicitacao.Etapa = Models.Enum.EEtapaSolicitacao.Cancelada;

            try
            {
                _context.Update(solicitacao);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolicitacaoExiste(solicitacao.Id))
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(int id, IFormCollection collection)
        {
            var solicitacao = await _context.Solicitacoes.FindAsync(id);
            _context.Solicitacoes.Remove(solicitacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool solicitacaoExiste(int id)
        private bool SolicitacaoExiste(int id)
        {
            return _context.Solicitacoes.Any(e => e.Id == id);
        }
    }
}