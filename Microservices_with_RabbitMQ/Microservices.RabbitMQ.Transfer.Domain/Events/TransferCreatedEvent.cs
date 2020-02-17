using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microservice.RabbitMQ.Domain.Events;

namespace Microservices.RabbitMQ.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
