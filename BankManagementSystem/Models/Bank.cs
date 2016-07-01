using BankManagementSystem.Utility;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementSystem.Models
{
    public class Bank
    {
        #region Fields & Properties
        public List<Account> Accounts { get; set; }

        private static Bank _instance;
        public static Bank Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Bank();
                return _instance;
            }
        }
        #endregion

        #region Constructors
        public Bank()
        {
            Accounts = new List<Account>();
        }
        #endregion

        #region Methods
        public void ChangeHoldersName(ulong id, string firstName,string lastName)
        {
            Accounts[GetIndex(id)].FirstName = firstName;
            Accounts[GetIndex(id)].LastName = lastName;
        }
        public AccountManagementState Add(Account account)
        {
            try
            {
                if (!Exist(account.Id))
                {
                    Accounts.Add(account);
                    return AccountManagementState.Successful;
                }
                else
                    return AccountManagementState.AccountAlreadyExist;
            }
            catch { return AccountManagementState.Unsuccessful; }
        }
        public AccountManagementState Modify(Account account)
        {
            try
            {
                if (Exist(account.Id))
                {
                    Accounts[GetIndex(account.Id)] = account;
                    return AccountManagementState.Successful;
                }
                else
                    return AccountManagementState.AccountDoesntExist;
            }
            catch { return AccountManagementState.Unsuccessful; }
        }
        public AccountManagementState Remove(ulong id)
        {
            try
            {
                if (Exist(id))
                {
                    Accounts.RemoveAt(GetIndex(id));
                    return AccountManagementState.Successful;
                }
                else
                    return AccountManagementState.AccountDoesntExist;
            }
            catch { return AccountManagementState.Unsuccessful; }
        }
        public AccountManagementState RemoveAt(int index)
        {
            try
            {
                Accounts.RemoveAt(index);
                return AccountManagementState.Successful;
            }
            catch { return AccountManagementState.Unsuccessful; }
        }
        public int GetIndex(ulong id)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Id == id)
                    return i;
            }
            return -1;
        }
        public Account GetAccount(ulong id)
        {
            return Accounts[GetIndex(id)];
        }
        public bool Exist(ulong id)
        {
            return Accounts.Any(account => account.Id == id);
        }
        public TransactionState Withdraw(ulong id, decimal amount)
        {
            try
            {
                if (!Exist(id))
                    return TransactionState.AccountDoesntExist;

                Account account = GetAccount(id);
                if (amount < account.Balance)
                {
                    account.Balance -= amount;
                    return TransactionState.Successful;
                }
                else
                    return TransactionState.NotEnoughCredit;
            }
            catch { return TransactionState.Unsuccessful; }
        }
        public TransactionState Deposit(ulong id, decimal amount)
        {
            try
            {
                if (!Exist(id))
                    return TransactionState.AccountDoesntExist;

                Account account = GetAccount(id);
                account.Balance += amount;
                return TransactionState.Successful;
            }
            catch { return TransactionState.Unsuccessful; }
        }
        public TransactionState Transfer(ulong sourceId, ulong destinationId, decimal amount)
        {
            try
            {
                if (!Exist(sourceId) || !Exist(destinationId))
                    return TransactionState.AccountDoesntExist;

                Account fromAccount = GetAccount(sourceId);
                Account toAccount = GetAccount(destinationId);
                if (amount < fromAccount.Balance)
                {
                    fromAccount.Balance -= amount;
                    toAccount.Balance += amount;
                    return TransactionState.Successful;
                }
                return TransactionState.NotEnoughCredit;
            }
            catch { return TransactionState.Unsuccessful; }
        }
        #endregion
    }
}
