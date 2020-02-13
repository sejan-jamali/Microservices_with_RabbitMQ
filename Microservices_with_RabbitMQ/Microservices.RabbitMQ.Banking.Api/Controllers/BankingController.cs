using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.RabbitMQ.Banking.Application.Interfaces;
using Microservices.RabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microservices.RabbitMQ.Banking.Application.Models;



namespace Microservices.RabbitMQ.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountServices _accountService;

        public BankingController(IAccountServices accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
