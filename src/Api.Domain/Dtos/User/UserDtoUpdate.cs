using System;
using System.ComponentModel.DataAnnotations;

namespace domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage = "Id é Obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter máximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é Obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail no formato inválido")]
        [StringLength(100, ErrorMessage = "E-mail deve ter máximo de {1} caracteres")]
        public string Email { get; set; }
    }
}
