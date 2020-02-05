using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Banking.Domain.Models;

namespace Microservices.RabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountServices
    {
        IEnumerable<Account> GetAccounts();
    }
}
