using System;


namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public sealed class Saldo
    {
        public static Saldo FromDecimal(decimal valor)
        {
            return new Saldo(valor);
        }

        public decimal Valor { get; private set; }

        private Saldo(decimal valor)
        {
            Valor = valor;
        }
    }
}
