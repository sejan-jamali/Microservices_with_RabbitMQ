using Microservices.RabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microservice.RabbitMQ.Domain.Bus;
using Microservices.RabbitMQ.Transfer.Application.Interfaces;
using Microservices.RabbitMQ.Transfer.Domain.Interfaces;


namespace Microservices.RabbitMQ.Transfer.Application.Services
{
    public class TransferServices : ITransferServices
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferServices(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        
    }
}
