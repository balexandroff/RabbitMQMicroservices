using RabbitMQMicroservices.Banking.Application.Interfaces;
using RabbitMQMicroservices.Banking.Domain.Interfaces;
using RabbitMQMicroservices.Banking.Domain.Models;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
