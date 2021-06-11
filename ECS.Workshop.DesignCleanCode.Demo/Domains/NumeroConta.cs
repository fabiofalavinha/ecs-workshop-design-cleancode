namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class NumeroConta
    {
        public int Value { get; set; }

        public static int contaInicial = 1;

        public NumeroConta ProximoNumeroConta()
        {
            Value = contaInicial;
            contaInicial++;
            return this;
        }

    }
}