using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microservice.RabbitMQ.Domain.Bus;
using Microservices.RabbitMQ.Transfer.Domain.Events;

namespace Microservices.RabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
            
        }
        Task IEventHandler<TransferCreatedEvent>.Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
