using domain.Dtos;
using System.Threading.Tasks;

namespace domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
