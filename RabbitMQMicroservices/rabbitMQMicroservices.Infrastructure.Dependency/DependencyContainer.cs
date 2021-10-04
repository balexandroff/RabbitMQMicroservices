using Microsoft.Extensions.DependencyInjection;
using RabbitMQMicroservices.Domain.Core.Bus;
using RabbitMQMicroservices.Infrastructure.Bus;

namespace RabbitMQMicroservices.Infrastructure.Dependency
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
