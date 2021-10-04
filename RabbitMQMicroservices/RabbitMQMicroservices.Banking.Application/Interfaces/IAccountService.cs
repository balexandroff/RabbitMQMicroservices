using RabbitMQMicroservices.Banking.Domain.Models;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
