using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio.Conta
{
    public class ContaEspecial : Conta
    {
        public ContaEspecial()
        {
            TaxaAdministrativa = new TaxaAdministrativa
            {
                Valor = 0m
            };
        }
    }
}
