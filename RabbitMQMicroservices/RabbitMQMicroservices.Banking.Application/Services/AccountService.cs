using RabbitMQMicroservices.Banking.Application.Interfaces;
using RabbitMQMicroservices.Banking.Application.Models;
using RabbitMQMicroservices.Banking.Domain.Commands;
using RabbitMQMicroservices.Banking.Domain.Interfaces;
using RabbitMQMicroservices.Banking.Domain.Models;
using RabbitMQMicroservices.Domain.Core.Bus;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;
        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount, 
                accountTransfer.ToAccount, 
                accountTransfer.TransferAmount);

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
