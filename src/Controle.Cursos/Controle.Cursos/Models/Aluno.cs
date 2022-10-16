using System;
using System.Collections.Generic;

namespace Controle.Cursos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual IEnumerable<Curso> Cursos { get; set; }
    }
}