using Api.Domain.Interfaces.Services.Pessoa;
using Api.Domain.Interfaces.Services.User;
using domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;
using service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IPessoaService, PessoaService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
           
        }
    }
}
