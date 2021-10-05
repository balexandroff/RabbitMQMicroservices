using RabbitMQMicroservices.Transfer.Domain.Models;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
