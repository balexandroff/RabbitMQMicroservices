using RabbitMQMicroservices.Domain.Core.Commands;

namespace RabbitMQMicroservices.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public int FromAccount { get; protected set; }

        public int ToAccount { get; protected set; }

        public decimal Amount { get; protected set; }
    }
}
