using System;


namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public sealed class Saldo
    {
        public static Saldo PorDecimal(decimal valor)
        {
            return new Saldo(valor);
        }

        public static Saldo PorInt(int valor)
        {
            return new Saldo(valor);
        }

        public void Adicionar(decimal valor)
        {
            Valor += valor;
        }

        public decimal Valor { get; private set; }

        private Saldo(decimal valor)
        {
            Valor = valor;
        }
    }
}
