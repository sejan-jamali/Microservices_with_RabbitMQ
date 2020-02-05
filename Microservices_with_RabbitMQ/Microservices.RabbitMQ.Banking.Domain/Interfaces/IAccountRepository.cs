using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Banking.Domain.Models;

namespace Microservices.RabbitMQ.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
