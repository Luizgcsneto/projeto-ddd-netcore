using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "{0} é um campo obrigatório para login")]
        [EmailAddress(ErrorMessage = "{0} em formato inválido")]
        [StringLength(100,ErrorMessage = "Tamanho acima do permitido deve ter no máximo {1}")]
        public string Email { get; set; }
    }
}
