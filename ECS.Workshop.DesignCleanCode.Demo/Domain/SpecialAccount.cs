using System.Collections.Generic;

namespace ECS.Workshop.DesignCleanCode.Demo.Domain
{
    public class SpecialAccount
    {
        public AccountNumber Number { get; set; }
        public List<Client> Clients { get; set; }
    }
}