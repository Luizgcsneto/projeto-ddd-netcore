using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Dtos.Pessoa
{
    public class PessoaDtoUpdate
    {
        [Required(ErrorMessage = "Id é Obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter máximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Idade é Obrigatório")]
        public int Age { get; set; }
    }
}
