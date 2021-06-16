using System;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class Agencia
    {
        public Guid Numero { get; private set; }

        public static Agencia Criar()
        {
            return new Agencia(Guid.NewGuid());
        }

        private Agencia(Guid numero)
        {
            Numero = numero;
        }
    }
}
