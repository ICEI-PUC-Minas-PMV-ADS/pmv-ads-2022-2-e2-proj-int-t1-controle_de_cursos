using System.Collections.Generic;

namespace Controle.Cursos.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int? InscricaoEstadual { get; set; }
        public virtual List<Curso> Cursos { get; set; }
    }
}