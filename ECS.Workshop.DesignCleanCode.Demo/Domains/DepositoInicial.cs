using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class DepositoInicial
    {
        public DateTime DataAberturaConta { get; set; }
        public double Valor { get; set; }

        public DepositoInicial(double valor)
        {
            DataAberturaConta = DateTime.Now;
            Valor = valor;
        }
    }
}
