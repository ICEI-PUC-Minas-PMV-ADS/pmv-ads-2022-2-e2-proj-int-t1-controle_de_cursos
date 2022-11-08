using Controle.Cursos.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Cursos.Models
{
    [Table("Solicitacao")]

    public class Solicitacao
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public EEtapaSolicitacao Etapa { get; set; }
        public DateTime? DataFechamento { get; set; }
        public virtual Aluno Aluno { get; set; }
        public int AlunoId { get; set; }
        public virtual Curso Curso { get; set; }
        public int CursoId { get; set; }
        public virtual Turma Turma { get; set; }
        public int? TurmaId { get; set; }
    }
}