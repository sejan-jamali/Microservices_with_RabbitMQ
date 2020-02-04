using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.RabbitMQ.Domain.Commands
{
    public abstract class Command
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
