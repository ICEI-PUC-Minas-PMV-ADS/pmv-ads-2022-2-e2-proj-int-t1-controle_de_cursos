using System.Collections.Generic;

namespace Controle.Cursos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }
    }
}