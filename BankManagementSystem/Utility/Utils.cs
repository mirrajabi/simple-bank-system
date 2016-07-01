using BankManagementSystem.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BankManagementSystem.Utility
{
    /// <summary>
    /// A Utility class used for simplifying tasks
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Converts a string set to MD5 string hash
        /// </summary>
        /// <param name="value">Value to be hashed</param>
        /// <returns>MD5 hash of input value</returns>
        public static string GetMD5String(string value)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(value);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString());

            return sb.ToString();
        }
        /// <summary>
        /// This will generate a new unique id based on other bank accounts
        /// </summary>
        /// <returns></returns>
        public static ulong GenerateId()
        {
            if (Bank.Instance.Accounts.Count == 0)
                return 0;
            return Bank.Instance.Accounts.Last().Id + 1;
        }
    }
}
