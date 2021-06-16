using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public class ContaEspecial : Conta
    {
        public ContaEspecial(ICliente[] clientes, Saldo saldo) : base(Taxa.PorDecimal(0M), clientes, saldo)
        {

        }

        public ContaEspecial(ICliente cliente, Saldo saldo) : base(Taxa.PorDecimal(0M), new ICliente[] { cliente } , saldo)
        {

        }
    }
}
