using RabbitMQMicroservices.Banking.Data.Context;
using RabbitMQMicroservices.Banking.Domain.Interfaces;
using RabbitMQMicroservices.Banking.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace RabbitMQMicroservices.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _dbContext;

        public AccountRepository(BankingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts.ToList();
        }
    }
}
