using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public interface IConta
    {
        NumeroConta NumeroConta { get; set; }
        DepositoInicial DepositoInicial { get; set; }
        Taxa Taxa { get; }


        IConta AbrirConta(ICliente cliente, double valorDepositoInicial);



    }
}
