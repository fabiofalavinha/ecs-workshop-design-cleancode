using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio.Conta
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            TaxaAdministrativa = new TaxaAdministrativa()
            {
                Valor = 0.05m
            };
        }
    }
}
