using RabbitMQMicroservices.Domain.Core.Bus;
using RabbitMQMicroservices.Transfer.Domain.Events;
using RabbitMQMicroservices.Transfer.Domain.Interfaces;
using RabbitMQMicroservices.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace RabbitMQMicroservices.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository) 
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog
            {
                FromAccount = @event.FromAmount,
                ToAccount = @event.ToAmount,
                Amount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}
