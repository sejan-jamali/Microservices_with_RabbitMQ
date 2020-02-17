using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microservice.RabbitMQ.Domain.Bus;
using Microservices.RabbitMQ.Banking.Application.Interfaces;
using Microservices.RabbitMQ.Banking.Application.Services;
using Microservices.RabbitMQ.Banking.Data.Context;
using Microservices.RabbitMQ.Banking.Data.Repository;
using Microservices.RabbitMQ.Banking.Domain.CommandHandlers;
using Microservices.RabbitMQ.Banking.Domain.Commands;
using Microservices.RabbitMQ.Banking.Domain.Interfaces;
using Microservices.RabbitMQ.Transfer.Application.Interfaces;
using Microservices.RabbitMQ.Transfer.Application.Services;
using Microservices.RabbitMQ.Transfer.Data.Context;
using Microservices.RabbitMQ.Transfer.Data.Repository;
using Microservices.RabbitMQ.Transfer.Domain.EventHandlers;
using Microservices.RabbitMQ.Transfer.Domain.Events;
using Microservices.RabbitMQ.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Microservice.Rabbit.Infra.InversionOfControl
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain
            services.AddTransient<IEventBus, Microservices.RabbitMQ.Infra.Bus.RabbitMQ>();

            //Domain Event
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();


            //Application
            services.AddTransient<IAccountServices, AccountServices>();
            services.AddTransient<ITransferServices, TransferServices>();

            //Domain Banking Command
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDBContext>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDBcontext>();
        }
    }
}
