


using Financial.Instruments.Api.Domain.Interfaces.IRepository;
using Financial.Instruments.Api.Infra.Data.Context;
using Financial.Instruments.Api.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Financial.Instruments.Api.Infra.Ioc
{
    public static class InjectionRepository
    {
        public static void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {

            serviceCollection.AddDbContext<FinancialContext>(context => context.UseSqlServer(configuration.GetSection("SqlConfiguration").GetSection("ConnectionString").Value));


            serviceCollection.AddScoped<IInstrumentRepository, InstrumentRepository>();
            serviceCollection.AddScoped<IInstrumentCategoriesRepository, InstrumentCategoriesRepository>();


        }
    }
}
