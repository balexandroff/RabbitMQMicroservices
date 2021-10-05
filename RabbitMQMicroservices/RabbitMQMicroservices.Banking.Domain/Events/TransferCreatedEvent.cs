using RabbitMQMicroservices.Domain.Core.Events;

namespace RabbitMQMicroservices.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int FromAmount { get; private set; }

        public int ToAmount { get; private set; }

        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            FromAmount = from;
            ToAmount = to;
            Amount = amount;
        }
    }
}
