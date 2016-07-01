using System;
using System.Collections.Generic;
using BankManagementSystem.Models;

namespace BankManagementSystem.Data
{
    [Serializable()]
    public class DbContext
    {
        public List<Account> Accounts { get; set; }
    }
}
