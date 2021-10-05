using RabbitMQMicroservices.Transfer.Data.Context;
using RabbitMQMicroservices.Transfer.Domain.Interfaces;
using RabbitMQMicroservices.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace RabbitMQMicroservices.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _dbContext;

        public TransferRepository(TransferDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TransferLog transferLog)
        {
            _dbContext.Add(transferLog);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _dbContext.TransferLogs.ToList();
        }
    }
}
