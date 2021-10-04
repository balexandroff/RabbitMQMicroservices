using RabbitMQMicroservices.Domain.Core.Events;
using System.Threading.Tasks;

namespace RabbitMQMicroservices.Domain.Core.Bus
{
    public interface IEventHandler<in Tevent> : IEventHandler where Tevent: Event
    {
        Task Handle(Tevent @event);
    }

    public interface IEventHandler { }
}
