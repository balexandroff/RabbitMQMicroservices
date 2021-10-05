using MediatR;
using RabbitMQMicroservices.Banking.Domain.Events;
using RabbitMQMicroservices.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMQMicroservices.Banking.Domain.Commands
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //Publish event to RabbitMQ
            _eventBus.Publish(new TransferCreatedEvent(
                request.FromAccount,
                request.ToAccount,
                request.Amount));

            return Task.FromResult(true);
        }
    }
}
