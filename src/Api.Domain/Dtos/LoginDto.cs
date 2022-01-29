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
        [Required(ErrorMessage = "Email é um campo obrigatório para login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        [StringLength(100,ErrorMessage = "Tamanha acima do permitido")]
        public string Email { get; set; }
    }
}
