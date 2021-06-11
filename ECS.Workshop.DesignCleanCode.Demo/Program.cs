using ECS.Workshop.DesignCleanCode.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Banco();
            var pessoa = new PessoaFisica()
            {
                Nome = "Joao"
            };

            Console.WriteLine("Press <ENTER> to exit application");
            Console.ReadKey();
        }
    }
}
