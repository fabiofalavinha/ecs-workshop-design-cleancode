using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta;
using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class Banco
    {
        public Agencia Agencia { get; private set; }
        public Conta[] Contas { get; private set; }


        public static Banco PorAgencia(Agencia agencia)
        {
           return new Banco(agencia);
        }

        private Banco(Agencia agencia)
        {
            Agencia = agencia;
        }

        public Conta CriarConta(ICliente cliente, Amount amount)
        {
            if(cliente == null)
            {
                System.Windows.Forms.MessageBox.Show($"Cliente deve ser informado para abertura de conta");
            }

            if(amount.Value > 10000)
            {
                return new ContaEspecial(cliente, Saldo.PorInt(amount.Value));
            }

            return new ContaCorrente(cliente, Saldo.PorInt(amount.Value));
        }
    }
}
