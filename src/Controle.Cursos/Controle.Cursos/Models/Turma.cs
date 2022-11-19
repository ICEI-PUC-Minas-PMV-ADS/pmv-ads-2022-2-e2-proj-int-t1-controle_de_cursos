using System;
using System.Collections.Generic;

namespace Controle.Cursos.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
        //public string? Periodo { get; set; }
        public string Periodo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public bool Concluida { get; set; }
    }
}