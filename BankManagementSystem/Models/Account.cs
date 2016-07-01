using System;

namespace BankManagementSystem.Models
{
    [Serializable()]
    public class Account
    {
        #region Properties
        /// <summary>
        /// The identification primary key
        /// </summary>
        public ulong Id { get; set; }
        /// <summary>
        /// FirstName of the account holder
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// LastName of the account holder
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Holders Address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Holders PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Hashed password of holder
        /// </summary>
        public string PasswordHash { get; set; }
        /// <summary>
        /// Accounts balance
        /// </summary>
        public decimal Balance { get; set; }
        #endregion
    }
}
