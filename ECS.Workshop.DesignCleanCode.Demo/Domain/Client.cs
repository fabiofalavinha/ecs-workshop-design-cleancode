namespace ECS.Workshop.DesignCleanCode.Demo.Domain
{
    public class Client
    {
        public string ClientName { get; set; }

        public void Name(string name)
        {
            ClientName = name;
        }
    }
}
