using RabbitMQMicroservices.Domain.Core.Events;
using System;

namespace RabbitMQMicroservices.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
