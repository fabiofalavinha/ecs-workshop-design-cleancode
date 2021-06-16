using ECS.Workshop.DesignCleanCode.Demo.Domains;
using ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa;
using ECS.Workshop.DesignCleanCode.Demo.Repositories;
using System;

namespace ECS.Workshop.DesignCleanCode.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bancoRepository = new BancoRepository();
            var agencia = Agencia.Criar();
            var banco = Banco.PorAgencia(agencia);
            bancoRepository.Registro(banco);

            //var bancoB = Banco.PorAgencia(agencia);
            //bancoRepository.Registro(bancoB);

            var joao = PessoaFisica.ApartirDe(Nome.PorString("João Alves da Silva"), CPF.ApartirString("236.859.000-56"));
            var contaEspecialJoao = banco.CriarConta(joao, Amount.FromInt(15000));
            bancoRepository.RegistrarConta(contaEspecialJoao);

            //bancoRepository.RegistrarConta(contaEspecialJoao);

            Console.WriteLine($"Saldo conta do joao:  { contaEspecialJoao.Saldo.Valor }");
            bancoRepository.Depositar(contaEspecialJoao, Amount.FromInt(200));
            Console.WriteLine($"Novo Saldo conta do joao:  { contaEspecialJoao.Saldo.Valor }");

            bancoRepository.RegistrarConta(contaEspecialJoao);

            var maria = PessoaFisica.ApartirDe(Nome.PorString("Maria Alves da Silva"), CPF.ApartirString("999.781.810-59"));
            var contaCorrenteMaria = banco.CriarConta(maria, Amount.FromInt(500));
            bancoRepository.RegistrarConta(contaCorrenteMaria);

            Console.WriteLine("Press <ENTER> to exit application");
            Console.ReadKey();
        }
    }
}
