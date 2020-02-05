using System;
using System.Collections.Generic;
using System.Text;
using Microservice.RabbitMQ.Domain.Bus;
using Microsoft.Extensions.DependencyInjection;


namespace Microservice.Rabbit.Infra.InversionOfControl
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain
            services.AddTransient<IEventBus, Microservices.RabbitMQ.Infra.Bus.RabbitMQ>();

        }
    }
}
