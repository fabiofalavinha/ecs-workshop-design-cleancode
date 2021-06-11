namespace ECS.Workshop.DesignCleanCode.Demo.Domain
{
    public class AccountNumber
    {
        
        public string Value { get; private set; }

        internal AccountNumber(string number)
        {
            Value = number;
        }
        public AccountNumber From(string number)
        {
            return new AccountNumber(number);
        }
    }
}
