using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Samuele", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            Console.WriteLine("Operations:");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine($"After a $500 withdrawal, the Balance is ${account.Balance}.");
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine($"After a $100 deposit, the Balance is ${account.Balance}.");
            Console.WriteLine(account.GetAccountHistory());
        
            //test initial balance must be positive
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account wit negative balance");
                Console.WriteLine(e.ToString());
                throw;
            }
        
            //test for a negative balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
                throw;
            }
        
        }
    }
}
