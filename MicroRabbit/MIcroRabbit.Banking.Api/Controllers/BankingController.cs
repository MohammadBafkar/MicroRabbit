using System.Collections.Generic;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using MicroRabbit.Banking.Application.Models;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    public class BankingController : Controller
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        // POST api/banking
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}