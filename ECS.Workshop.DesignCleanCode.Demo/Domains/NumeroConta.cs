namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class NumeroConta
    {
        public int Value { get; set; }

        public static int contaInicial = 0;

        public NumeroConta ProximoNumeroConta()
        {
            return new NumeroConta(contaInicial++);
        }

    }
}