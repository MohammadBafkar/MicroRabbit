using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MIcroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}