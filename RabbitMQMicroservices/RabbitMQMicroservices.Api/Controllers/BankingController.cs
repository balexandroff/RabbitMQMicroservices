using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RabbitMQMicroservices.Banking.Application.Interfaces;
using RabbitMQMicroservices.Banking.Domain.Models;

namespace RabbitMQMicroservices.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        private readonly ILogger<BankingController> _logger;

        public BankingController(IAccountService accountService, ILogger<BankingController> logger)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
    }
}
