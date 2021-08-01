using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpResponse;
using HttpResponse.Models;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        // GET api/v1/transfer
        [HttpGet]
        public Result<IEnumerable<TransferLog>> Get()
        {
            return ResponseResult<IEnumerable<TransferLog>>.Success(_transferService.GetTransferLogs());
        }
    }
}
