﻿using System;
using System.Collections.Generic;
using System.Text;
using Microservice.RabbitMQ.Domain.Bus;
using Microservices.RabbitMQ.Banking.Application.Interfaces;
using Microservices.RabbitMQ.Banking.Application.Services;
using Microservices.RabbitMQ.Banking.Data.Context;
using Microservices.RabbitMQ.Banking.Data.Repository;
using Microservices.RabbitMQ.Banking.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Microservice.Rabbit.Infra.InversionOfControl
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain
            services.AddTransient<IEventBus, Microservices.RabbitMQ.Infra.Bus.RabbitMQ>();

            //Application
            services.AddTransient<IAccountServices, AccountServices>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDBContext>();
        }
    }
}
