using System;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public sealed class Nome
    {
        public static Nome PorString(string valor)
        {
            return new Nome(valor);
        }

        public string Valor { get; private set; }

        public Nome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("Nome da pessoa é obrigatório");
            }

            Valor = valor;
        }
    }
}
