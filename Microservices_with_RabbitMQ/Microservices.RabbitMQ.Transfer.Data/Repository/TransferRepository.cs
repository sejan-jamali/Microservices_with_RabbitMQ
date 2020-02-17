using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Transfer.Data.Context;
using Microservices.RabbitMQ.Transfer.Domain.Interfaces;
using Microservices.RabbitMQ.Transfer.Domain.Models;

namespace Microservices.RabbitMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDBcontext _context;

        public TransferRepository(TransferDBcontext context)
        {
            _context = context;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }
    }
}
