namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public class PessoaFisica
    {
        public Pessoa Pessoa { get; set; }
        public CPF CPF { get; set; }

        public PessoaFisica(Nome nome, CPF Cpf)
        {
            Pessoa = Pessoa.PorNome(nome);
            CPF = Cpf;
        }
    }
}
