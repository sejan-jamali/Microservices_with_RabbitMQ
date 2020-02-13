using Microservices.RabbitMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microservice.RabbitMQ.Domain.Bus;
using Microservices.RabbitMQ.Banking.Application.Interfaces;
using Microservices.RabbitMQ.Banking.Domain.Interfaces;
using Microservices.RabbitMQ.Banking.Application.Models;
using Microservices.RabbitMQ.Banking.Domain.Commands;

namespace Microservices.RabbitMQ.Banking.Application.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountServices(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferAccount = new CreateTransferCommand(
                accountTransfer.AccountFrom,
                accountTransfer.ToAccount,
                accountTransfer.Transfer
                );
            _bus.SendCommand(createTransferAccount);
        }
    }
}
