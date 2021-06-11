
namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public class ContaCorrente : Conta
    {
        //Pessoa
        //Taxa

        public ContaCorrente() : base(Taxa.PorDecimal(0.05M))
        {

        }
        
    }
}
