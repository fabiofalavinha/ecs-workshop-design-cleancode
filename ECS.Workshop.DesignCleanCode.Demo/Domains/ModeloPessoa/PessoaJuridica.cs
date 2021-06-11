namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public class PessoaJuridica
    {
        public Pessoa Pessoa { get; set; }
        public CNPJ CNPJ { get; set; }

        public PessoaJuridica(Nome nome, CNPJ Cnpj)
        {
            Pessoa = Pessoa.PorNome(nome);
            CNPJ = Cnpj;
        }
    }
}
