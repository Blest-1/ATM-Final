using System;
namespace ATM_Final
{
    public class BankAccount
    {
        public string FullName { get; set; }
        public Int64 AccountNumber { get; set; }
        public Int64 CardNumber { get; set; }
        public Int64 PinCode { get; set; }
        public decimal Balance { get; set; }

        public bool isLocked { get; set; }
        private static BankAccount selectedAccount;
        private static BankAccount inputAccount;

        public void Initialization()
        {
            
            {
                new BankAccount() { FullName = "Matt", AccountNumber = 333111, CardNumber = 123, PinCode = 1111, Balance = 2000.00m, isLocked = false };
                new BankAccount() { FullName = "Oscar", AccountNumber = 111222, CardNumber = 456, PinCode = 2222, Balance = 1500.30m, isLocked = true };
                new BankAccount() { FullName = "Osiris", AccountNumber = 888555, CardNumber = 789, PinCode = 3333, Balance = 2900.12m, isLocked = false };
            }
        }
    }
}
