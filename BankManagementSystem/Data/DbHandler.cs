using BankManagementSystem.Models;
using BankManagementSystem.Utility;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankManagementSystem.Data
{
    public class DbHandler
    {
        public static RecordIOState Save()
        {
            try
            {
                using (Stream stream = File.Open("db.dat", FileMode.Create))
                {
                    BinaryFormatter binaryFormater = new BinaryFormatter();
                    DbContext dbContext = new DbContext() { Accounts = Bank.Instance.Accounts };
                    binaryFormater.Serialize(stream, dbContext);
                }
                return RecordIOState.Successful;
            } catch { return RecordIOState.Unsuccessful; }
        }
        public static RecordIOState Load()
        {
            try
            {
                using (Stream stream = File.Open("db.dat", FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    DbContext db = (DbContext)binaryFormatter.Deserialize(stream);
                    Bank.Instance.Accounts = db.Accounts;
                }
                return RecordIOState.Successful;
            }
            catch { return RecordIOState.Unsuccessful; }
        }
    }
}
