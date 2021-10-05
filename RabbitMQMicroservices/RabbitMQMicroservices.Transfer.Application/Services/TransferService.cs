using RabbitMQMicroservices.Transfer.Application.Interfaces;
using RabbitMQMicroservices.Transfer.Domain.Interfaces;
using RabbitMQMicroservices.Transfer.Domain.Models;
using RabbitMQMicroservices.Domain.Core.Bus;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;
        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
