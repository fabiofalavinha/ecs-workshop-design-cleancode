namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public class PessoaFisica : ICliente
    {
        public Nome Nome { get; }
        public CPF CPF { get; }

        public static PessoaFisica ApartirDe(Nome nome, CPF cpf)
        {
            return new PessoaFisica(nome, cpf);
        }

        private PessoaFisica(Nome nome, CPF Cpf)
        {
            Nome = nome;
            CPF = Cpf;
        }
    }
}
