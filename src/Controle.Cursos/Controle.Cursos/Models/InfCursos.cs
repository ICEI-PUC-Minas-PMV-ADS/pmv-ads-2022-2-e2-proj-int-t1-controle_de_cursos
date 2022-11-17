using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Cursos.Models
{

    [Table("InfCursos")]
    public class InfCursos
    {
        [Key]
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string CargaHoraria { get; set; }
    }
}
