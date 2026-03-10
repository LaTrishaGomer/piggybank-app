using System.Linq.Expressions;

namespace BankAccountProject
{
    public class BankAccount
    {
        protected decimal Balance;
        public string AccountHolder;

        public BankAccount(string accountHolder, decimal startingBalance)
        {
            AccountHolder = accountHolder;
            Balance = startingBalance;
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new Exception("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid amount.");
            }
            else if (amount > Balance)
            {
                throw new Exception("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
            }
        }
        
        public decimal CheckBalance()
        {
            return Balance;
        }


    }
}