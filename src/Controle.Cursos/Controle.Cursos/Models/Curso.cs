using Controle.Cursos.Constantes;
using Controle.Cursos.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle.Cursos.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMessage.NOME_OBRIGATORIO)]
        public string Nome { get; set; }

        [DisplayName("Carga Horária")]
        public DateTime Horario { get; set; }
        public int? FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public EModalidade Modalidade { get; set; }
        public virtual IEnumerable<Turma> Turmas { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Tipo")]
        public string Tipo { get; set; }
    }
}