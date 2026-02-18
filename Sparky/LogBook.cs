using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    public interface ILogBook
    {
        void Message(string message);
        bool LogToDb(string message);
        bool LogBalanceAfterWithdrawal(int balance);
        string MessageWithReturnStr(string message);
    }
    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        bool ILogBook.LogBalanceAfterWithdrawal(int balance)
        {
            if (balance >= 0)
            {
                Console.WriteLine($"Balance after withdrawal: {balance}");
                return true; // Log successful

            }
            else
            {
                Console.WriteLine("Balance is zero or negative after withdrawal.");
                return false; // Log unsuccessful

            }
        }

        bool ILogBook.LogToDb(string message)
        {
            // Simulate logging to a database
            Console.WriteLine(message);
            return true; // Assume logging to DB is successful

        }

        string ILogBook.MessageWithReturnStr(string message)
        {
            Console.WriteLine(message);
            return message; // Return the message for demonstration purposes
        }
    }
    //public class LogFakker : ILogBook
    //{
    //    public void Message(string message)
    //    {
    //        // Simulate logging to a fake log
    //    }
    //}
}
