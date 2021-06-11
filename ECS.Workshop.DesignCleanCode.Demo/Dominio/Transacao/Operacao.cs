using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio.Transacao
{
    public abstract class Operacao
    {
        public abstract Recibo ExecutarTransacao();
    }
}
