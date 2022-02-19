using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Dtos.Contact
{
    public class ContactDto
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(80, ErrorMessage = "O campo nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O campo E-mail deve ter no máximo {1} caracteres")]
        [EmailAddress(ErrorMessage = "{0} no formato inválido")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
