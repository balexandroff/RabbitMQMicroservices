using System;

namespace RabbitMQMicroservices.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime TimeStamp { get; protected set; }

        public Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
