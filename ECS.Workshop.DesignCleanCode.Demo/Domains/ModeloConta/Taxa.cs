namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public sealed class Taxa
    {
        public static Taxa PorDecimal(decimal valor)
        {
            return new Taxa(valor);
        }

        public decimal Valor { get; private set; }

        private Taxa(decimal valor)
        {
            Valor = valor;
        }
    }
}
