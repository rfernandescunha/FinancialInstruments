

using Financial.Instruments.Api.Domain.Interfaces.IServices;
using Financial.Instruments.Api.Domain.Services;

namespace Financial.Instruments.Api.Infra.Ioc
{
    public static class InjectionService
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IInstrumentServices, InstrumentServices>();
            serviceCollection.AddScoped<IInstrumentCategoriesServices, InstrumentCategoriesServices>();

        }
    }
}