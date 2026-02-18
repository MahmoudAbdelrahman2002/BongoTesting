using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sparky
{
    public class BankAccount
    {
        public int Balance { get; set; }
        private readonly ILogBook _logBook;
        public BankAccount(ILogBook logBook)
        {
            _logBook = logBook;
            Balance = 0;

        }
        public bool Deposit(int amount)
        {
            _logBook.Message($"Depositing {amount}");
            if (amount <= 0)
            {
                _logBook.Message("Deposit amount must be positive.");
                return false;
            }
            _logBook.Message($"Current balance before deposit: {Balance}");
            Balance += amount;
            _logBook.Message($"New balance after deposit: {Balance}");
            return true;
        }
        public bool Withdraw(int amount)
        {
            if(amount<=Balance)
            {
                _logBook.LogToDb("Withdrawal successful.");
                Balance -= amount;
                return _logBook.LogBalanceAfterWithdrawal(Balance);
            }
            return _logBook.LogBalanceAfterWithdrawal(Balance-amount);

        }
        public int GetBalance()
        {
            _logBook.Message($"Getting balance: {Balance}");
            return Balance;
        }
    }
}
