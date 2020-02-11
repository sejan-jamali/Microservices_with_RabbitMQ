using Microservice.RabbitMQ.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.RabbitMQ.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
