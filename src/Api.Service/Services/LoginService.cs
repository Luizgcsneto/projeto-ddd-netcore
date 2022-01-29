using Api.Domain.Repository;
using domain.Dtos;
using domain.Entities;
using domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
               return await _repository.FindByLogin(user.Email);
            }
            else
            {
                return null;
            }
        }
    }
}
