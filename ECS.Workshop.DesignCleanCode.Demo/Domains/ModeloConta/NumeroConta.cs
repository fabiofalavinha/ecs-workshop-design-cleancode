namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloConta
{
    public sealed class NumeroConta
    {
        public static NumeroConta Gerar()
        {
            return new NumeroConta();
        }

        public int Valor { get; private set; }

        private NumeroConta()
        {
           //gerar
        }
    }
}
