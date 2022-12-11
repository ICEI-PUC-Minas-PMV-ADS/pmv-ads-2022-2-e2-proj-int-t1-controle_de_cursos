﻿using Microsoft.EntityFrameworkCore;
using Controle.Cursos.Models;

namespace Controle.Cursos.Models.Context
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public DbSet<UsuarioModel> UsuarioModel{ get; set; }
    }
}
