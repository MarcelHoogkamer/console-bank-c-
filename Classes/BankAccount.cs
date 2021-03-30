using System;

namespace BankingApp.Classes
{
    class BankAccount
    {
        public BankAccount(Client client, int balance, string type)
        {
            Client = client;
            Balance = balance;
            Type = type;
        }

        public Client Client { get; }
        public int Balance { get; set; }
        public string Type { get; }

        public int CheckBalance()
        {
            return Balance;
        }

        public void Withdraw(int amount)
        {
            if (Balance <= amount)
            {
                Console.WriteLine("This transaction is not possible. Insufficient funds.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Succeful withdrawal. New balance: " + CheckBalance());
            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Thank you, your new balance is: " + CheckBalance());
        }
    }
}
