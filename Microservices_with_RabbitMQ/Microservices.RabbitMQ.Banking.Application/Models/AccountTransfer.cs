using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.RabbitMQ.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int AccountFrom { get; set; }
        public int ToAccount { get; set; }
        public decimal Transfer { get; set; }
    }
}
