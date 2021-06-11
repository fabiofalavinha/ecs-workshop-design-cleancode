using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class ContaCorrente : IConta
    {
        public NumeroConta NumeroConta { get; set; }
        public Taxa Taxa { get { return new Taxa(0.05); } }

        public IConta AbrirConta(ICliente cliente, double valorDepositoInicial)
        {
            throw new NotImplementedException();
        }
    }
}
