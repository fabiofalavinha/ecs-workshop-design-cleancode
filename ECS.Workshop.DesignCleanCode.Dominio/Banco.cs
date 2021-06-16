using ECS.Workshop.DesignCleanCode.Demo.Dominio.Conta;
using ECS.Workshop.DesignCleanCode.Demo.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio
{
    public class Banco : IEntidadePadrao
    {
        public int Id { get; set; }
        public Agencia Agencia { get; set; }
    }
}
