using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Microservices.RabbitMQ.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand, IRequest<bool>
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
