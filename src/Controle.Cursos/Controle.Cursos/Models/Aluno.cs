﻿using Controle.Cursos.Models.Enum;
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
        public virtual IEnumerable<Turma> Turmas { get; set; }
        public virtual IEnumerable<Solicitacao> Solicitacoes { get; set; }
        public ESexo Sexo { get; set; }
    }
}