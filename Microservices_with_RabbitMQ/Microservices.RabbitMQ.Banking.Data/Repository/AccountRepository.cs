using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Banking.Data.Context;
using Microservices.RabbitMQ.Banking.Domain.Interfaces;
using Microservices.RabbitMQ.Banking.Domain.Models;

namespace Microservices.RabbitMQ.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDBContext _context;

        public AccountRepository(BankingDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
