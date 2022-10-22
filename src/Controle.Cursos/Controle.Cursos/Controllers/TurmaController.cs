using Controle.Cursos.Models;
using Controle.Cursos.Models.Context;
using Controle.Cursos.Models.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Cursos.Controllers
{
    public class TurmaController : Controller
    {
        private readonly ApplicationDbContext _context;

        private static int cursoIdSelected;

        //private static IEnumerable<Solicitacao> solicitacoes;

        public TurmaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Turmas.ToListAsync());
        }

        //public async Task<IActionResult> Details(int? id) {
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var turma = await _context.Turmas
        //        .FirstOrDefaultAsync(c => c.Id == id);

        //    if (turma == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(turma);
        //}

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
            List<Curso> cursos = ObterListaDeCursosComSolicitacoesAbertas();

            if (cursos.Any())
            {
                ViewBag.Cursos = cursos;
                cursoIdSelected = cursos.FirstOrDefault().Id;
            }

            var solicitacoes = ObterSolicitacoesAbertasPorCurso(cursoIdSelected);

            if (solicitacoes != null)
            {
                ViewBag.Solicitacoes = solicitacoes;
            }

            return View();
        }

        private List<Curso> ObterListaDeCursosComSolicitacoesAbertas()
        {
            var solicitacoesAbertas = _context.Solicitacoes
                .Select(s => s)
                .Where(s =>  s.Etapa == EEtapaSolicitacao.Aberta)
                .Select(s => s.Curso).Distinct().ToList();
            return solicitacoesAbertas;
        }

        public ActionResult SolicitacaoPartial(
            [Bind("Id")] int cursoId)
        {
            cursoIdSelected = cursoId;

            var cursos = ObterListaDeCursosComSolicitacoesAbertas();

            if (cursos != null)
            {
                ViewBag.Cursos = cursos;
            }
            
            var solicitacoes = ObterSolicitacoesAbertasPorCurso(cursoId);

            if (solicitacoes != null)
            {
                ViewBag.Solicitacoes = solicitacoes;
            }

            return View("Create");
        }

        private IQueryable<Solicitacao> ObterSolicitacoesAbertasPorCurso(int cursoId)
        {
            return _context.Solicitacoes
                .Select(s => s)
                .Where(s => s.CursoId == cursoId
                && s.Etapa != EEtapaSolicitacao.Concluida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBtn()
        {
            if (ModelState.IsValid)
            {
                var solicitacoes = ObterSolicitacoesAbertasPorCurso(cursoIdSelected);

                foreach (var solicitacao in solicitacoes)
                {
                    solicitacao.Etapa = EEtapaSolicitacao.Concluida;
                }

                var listaAlunosId = solicitacoes.Select(s => s.Aluno).ToList();

                Turma turma = new Turma
                {
                    Alunos = _context.Alunos
                        .Select(a => a)
                        .Where(a =>  listaAlunosId.Contains(a)).ToList(),
                    Concluida = false,
                    CursoId = cursoIdSelected
                };

                _context.Add(turma);
                _context.UpdateRange(solicitacoes);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View("Create");
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