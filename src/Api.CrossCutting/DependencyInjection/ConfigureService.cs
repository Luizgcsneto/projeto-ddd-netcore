using Api.Domain.Interfaces.Services.Pessoa;
using Api.Domain.Interfaces.Services.User;
using Api.service.Services;
using domain.Interfaces.Services.Contact;
using domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;
using service.Services;

namespace crossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IPessoaService, PessoaService>();
            serviceCollection.AddTransient<IContactService, ContactService>();
           
        }
    }
}
