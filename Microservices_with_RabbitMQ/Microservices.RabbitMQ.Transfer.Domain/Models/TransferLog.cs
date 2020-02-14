using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.RabbitMQ.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public string FromAccount { get; set; }
        public decimal ToAccount { get; set; }
        public decimal TransferAmount { get; set; }

    }
}
