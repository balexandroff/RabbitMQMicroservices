using RabbitMQMicroservices.Banking.Domain.Models;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
