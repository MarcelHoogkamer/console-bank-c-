using System;

namespace BankingApp.Classes
{
    class Client
    {
        public Client(int id, string name)
        {
            Id = id;
            Name = name;
            DateJoined = DateTime.Now;
        }

        public int Id { get; }
        public string Name { get; }
        public DateTime DateJoined { get; }

    }
}
