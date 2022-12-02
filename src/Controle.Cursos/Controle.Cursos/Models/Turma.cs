using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Controle.Cursos.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }

        [DisplayName("Período")]
        public string? Periodo { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Data Início")]
        public DateTime? DataInicio { get; set; }

        [DisplayName("Data Finalização")]
        public DateTime? DataFinalizacao { get; set; }

        [DisplayName("Concluída")]
        public bool Concluida { get; set; }
    }
}