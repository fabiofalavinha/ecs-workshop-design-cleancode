using ECS.Workshop.DesignCleanCode.Demo.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ECS.Workshop.DesignCleanCode.Demo.Domain
{
    public class Account
    {
        public AccountNumber Number { get; set; }
        public List<Client> Clients { get; set; }

        public void AddClients(Client client)
        {
            Clients.Add(client);
        }

        public AccountNumber AccountNumber(string accountNumber)
        {
            return new AccountNumber(accountNumber);
        }
    }
}
