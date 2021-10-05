using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RabbitMQMicroservices.Transfer.Application.Interfaces;
using RabbitMQMicroservices.Transfer.Domain.Models;
using System.Collections.Generic;

namespace RabbitMQMicroservices.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ILogger<TransferController> _logger;
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService, ILogger<TransferController> logger)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());   
        }
    }
}
