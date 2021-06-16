namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public class PessoaJuridica : ICliente
    {
        public Nome Nome { get; }
        public CNPJ CNPJ { get; private set; }

        public PessoaJuridica(Nome nome, CNPJ Cnpj)
        {
            Nome = nome;
            CNPJ = Cnpj;
        }
    }
}
