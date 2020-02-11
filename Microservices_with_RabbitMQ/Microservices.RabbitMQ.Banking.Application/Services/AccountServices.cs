using Microservices.RabbitMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microservices.RabbitMQ.Banking.Application.Interfaces;
using Microservices.RabbitMQ.Banking.Domain.Interfaces;
using Microservices.RabbitMQ.Banking.Application.Models;

namespace Microservices.RabbitMQ.Banking.Application.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;

        public AccountServices(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            throw new NotImplementedException();
        }
    }
}
