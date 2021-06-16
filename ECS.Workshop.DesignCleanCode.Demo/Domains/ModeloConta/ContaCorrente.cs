
using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(ICliente cliente, Saldo saldo) : base(Taxa.PorDecimal(0.05M), new ICliente[] { cliente }, saldo)
        {

        }
    }
}
