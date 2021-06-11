using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class ClientePessoaJuridica : ICliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cpnj Cnpj { get; set; }
    }
}
