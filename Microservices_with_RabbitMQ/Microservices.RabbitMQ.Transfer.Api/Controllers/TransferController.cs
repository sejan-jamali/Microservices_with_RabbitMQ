using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.RabbitMQ.Transfer.Application.Interfaces;
using Microservices.RabbitMQ.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Microservices.RabbitMQ.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferServices _transferServices;

        public TransferController(ITransferServices transferServices)
        {
            _transferServices = transferServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return Ok(_transferServices.GetTransferLogs());
        }
    }
}
