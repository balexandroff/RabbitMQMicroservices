using RabbitMQMicroservices.Transfer.Domain.Models;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
