using Controle.Cursos.Constantes;
using System;
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
        public DateTime Horario { get; set; }
    }
}