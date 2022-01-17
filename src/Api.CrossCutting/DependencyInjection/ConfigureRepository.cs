using data.Context;
using data.Repository;
using domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace crossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddDbContext<MyContext>(p => p.UseSqlServer("Server=DESKTOP-36IVIOJ\\SQLEXPRESS;Database=dbApi;Trusted_Connection=True;"));
        }
    }
}
