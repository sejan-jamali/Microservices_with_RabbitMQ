using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Transfer.Domain.Models;

namespace Microservices.RabbitMQ.Transfer.Application.Interfaces
{
    public interface ITransferServices
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
