using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class Cpf
    {
        public string Valor { get; set; }

        public Cpf(string valor)
        {
            Valor = valor;
        }
    }
}
