using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta;
using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public abstract class Conta
    {
        public NumeroConta NumeroConta { get; private set; }
        public Saldo Saldo { get; private set; }
        public Taxa Taxa { get; private set; }
        public ICliente[] Clientes { get; private set; }

        public Conta(Taxa taxa, ICliente[] clientes, Saldo saldo)
        {
            NumeroConta = NumeroConta.Gerar();
            Taxa = taxa;
            Clientes = clientes;
            Saldo = saldo;
        }

        public void Depositar(Amount valor)
        {
            Saldo.Adicionar(valor.ToDecimal());
        }
    }
}
