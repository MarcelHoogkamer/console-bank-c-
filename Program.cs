using System;
using BankingApp.Classes;

namespace BankingApp
{ 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Mark's Banking App. May I have your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Thank you, " + name);
            Console.WriteLine("What type of bank account do you have (Savings, Business, Current)?");
            var type = Console.ReadLine();
            Console.WriteLine("What is your current balance?");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want to do? Type C to check your balance, D for a deposit, W for a withdrawal.");
            var query = Console.ReadLine();
            var newclient = new Client(1, name);
            var BankAccount = new BankAccount(newclient, balance, type);

            if (query == "C")
            {
                Console.WriteLine("Your current balance is: " + BankAccount.CheckBalance());
            }
            else if (query == "D")
            {
                Console.WriteLine("Type the amount you want to deposit.");
                var amount = Convert.ToInt32(Console.ReadLine());
                BankAccount.Deposit(amount);
            }
            else if (query == "W")
            {
                Console.WriteLine("How much do you want to withdraw?");
                var amount = Convert.ToInt32(Console.ReadLine());
                BankAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Invalid entry, closing Mark's Banking App...");
            }
        }
    }
}