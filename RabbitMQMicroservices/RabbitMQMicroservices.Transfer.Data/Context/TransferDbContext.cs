using Microsoft.EntityFrameworkCore;
using RabbitMQMicroservices.Transfer.Domain.Models;

namespace RabbitMQMicroservices.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
