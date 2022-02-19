using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Nome é Obrigatório")]
        [StringLength(60,ErrorMessage = "Nome deve ter máximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é Obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail no formato inválido")]
        [StringLength(100, ErrorMessage = "E-mail deve ter máximo de {1} caracteres")]
        public string Email { get; set; }
    }
}
