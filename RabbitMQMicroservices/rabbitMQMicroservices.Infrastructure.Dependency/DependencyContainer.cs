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
using RabbitMQMicroservices.Transfer.Application.Interfaces;
using RabbitMQMicroservices.Transfer.Application.Services;
using RabbitMQMicroservices.Transfer.Data.Context;
using RabbitMQMicroservices.Transfer.Data.Repository;
using RabbitMQMicroservices.Transfer.Domain.EventHandlers;
using RabbitMQMicroservices.Transfer.Domain.Events;
using RabbitMQMicroservices.Transfer.Domain.Interfaces;

namespace RabbitMQMicroservices.Infrastructure.Dependency
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.AddMediatR(typeof(RabbitMQBus).Assembly.GetTypes());

            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                return new RabbitMQBus(sp.GetService<IMediator>(), sp.GetRequiredService<IServiceScopeFactory>());
            });

            //Subscriotions
            services.AddTransient<TransferEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            
            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Aplication Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data Repositories
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            
            //Data Contexts
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
