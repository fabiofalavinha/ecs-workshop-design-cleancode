using ECS.Workshop.DesignCleanCode.Demo.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio.Conta
{
    public class Agencia : IEntidadePadrao
    {

        public int Id { get; set; }
        public Conta[] Contas { get; set; }
        
        public void AdicionarConta(Cliente cliente)
        {
            
        }
    }
}
