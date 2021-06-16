using ECS.Workshop.DesignCleanCode.Demo.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio
{
    public abstract class Cliente : IEntidadePadrao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorInicial { get; set; }

    }
}
