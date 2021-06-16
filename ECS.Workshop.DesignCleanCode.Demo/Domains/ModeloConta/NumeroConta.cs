using System;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public sealed class NumeroConta
    {
        public static NumeroConta Gerar()
        {
            return new NumeroConta();
        }

        public Guid Valor { get; private set; }

        private NumeroConta()
        {
            Valor = Guid.NewGuid();
        }
    }
}
