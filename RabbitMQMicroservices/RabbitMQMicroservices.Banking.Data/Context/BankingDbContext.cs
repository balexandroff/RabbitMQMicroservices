using Microsoft.EntityFrameworkCore;
using RabbitMQMicroservices.Banking.Domain.Models;

namespace RabbitMQMicroservices.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
