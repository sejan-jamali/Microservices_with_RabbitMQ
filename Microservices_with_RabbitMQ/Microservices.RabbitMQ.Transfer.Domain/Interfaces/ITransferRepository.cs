using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Transfer.Domain.Models;

namespace Microservices.RabbitMQ.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
