using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQMicroservices.Banking.Application.Interfaces;
using RabbitMQMicroservices.Banking.Application.Services;
using RabbitMQMicroservices.Banking.Data.Context;
using RabbitMQMicroservices.Banking.Data.Repository;
using RabbitMQMicroservices.Banking.Domain.Commands;
using RabbitMQMicroservices.Banking.Domain.Interfaces;
using RabbitMQMicroservices.Domain.Core.Bus;
using RabbitMQMicroservices.Infrastructure.Bus;

namespace RabbitMQMicroservices.Infrastructure.Dependency
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.AddMediatR(typeof(RabbitMQBus).Assembly.GetTypes());

            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Aplication Services
            services.AddTransient<IAccountService, AccountService>();

            //Data Repositories
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
