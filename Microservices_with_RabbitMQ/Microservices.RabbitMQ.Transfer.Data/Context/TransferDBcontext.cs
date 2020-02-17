using Microservices.RabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.RabbitMQ.Transfer.Data.Context
{
    public class TransferDBcontext : DbContext
    {
        public TransferDBcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
