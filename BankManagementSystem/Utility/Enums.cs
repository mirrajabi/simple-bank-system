namespace BankManagementSystem.Utility
{
    public enum TransactionState
    {
        Successful,
        Unsuccessful,
        NotEnoughCredit,
        AccountDoesntExist
    }
    public enum AccountManagementState
    {
        Successful,
        Unsuccessful,
        AccountAlreadyExist,
        AccountDoesntExist
    }
    public enum RecordIOState
    {
        Successful,
        Unsuccessful
    }
}
