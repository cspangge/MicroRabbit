using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HttpResponse;
using HttpResponse.Models;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/v1/banking
        [HttpGet]
        public Result<IEnumerable<Account>> Get()
        {
            return ResponseResult<IEnumerable<Account>>.Success(_accountService.GetAccounts());
        }

        // POST api/v1/banking
        [HttpPost]
        public ActionResult<IEnumerable<Account>> Post([FromBody]AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
