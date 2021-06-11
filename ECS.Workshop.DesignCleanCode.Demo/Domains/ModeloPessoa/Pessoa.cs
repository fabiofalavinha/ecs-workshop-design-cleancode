
namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public class Pessoa
    {
        public Nome Nome { get; private set; }

        public static Pessoa PorNome(Nome nome)
        {
            return new Pessoa(nome);
        }

        private Pessoa(Nome nome)
        {
            Nome = nome;
        }
    }
}
