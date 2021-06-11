using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public abstract class Conta
    {
        public NumeroConta NumeroConta { get; private set; }
        public Saldo Saldo { get; set; }
        public Taxa Taxa { get; set; }


        public Conta(Taxa taxa)
        {
            NumeroConta = NumeroConta.Gerar();
            Taxa = taxa;
        }
    }
}
