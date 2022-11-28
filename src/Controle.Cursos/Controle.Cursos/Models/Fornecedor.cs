using System.Collections.Generic;
using System.ComponentModel;

namespace Controle.Cursos.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [DisplayName("Inscrição Estadual")]
        public int? InscricaoEstadual { get; set; }
        public virtual List<Curso> Cursos { get; set; }
    }
}