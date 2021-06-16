using ECS.Workshop.DesignCleanCode.Demo.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio.Transacao
{
    public abstract class Operacao : IEntidadePadrao
    {
        public int Id { get; set; }

        public abstract Recibo ExecutarTransacao();
    }
}
