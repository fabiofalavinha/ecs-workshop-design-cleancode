using ECS.Workshop.DesignCleanCode.Demo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class ContaEspecial : IConta
    {
        private const double ValorMinimoDeposito = 10000;

        public NumeroConta NumeroConta { get; set; }
        public DepositoInicial DepositoInicial { get; set; }
        public Taxa Taxa { get { return new Taxa(0.00); } }

        

        public ContaEspecial(NumeroConta numeroConta,DepositoInicial depositoInicial)
        {
            NumeroConta = numeroConta;
            DepositoInicial = depositoInicial;
        }

        public IConta AbrirConta(ICliente cliente, double valorDepositoInicial)
        {
            if (valorDepositoInicial < ValorMinimoDeposito)
            {
                throw new ContaException("O valor do depósito não permite abrir uma conta especial");
            }

            var numeroConta = new NumeroConta();
            var novaConta = new ContaEspecial(numeroConta.ProximoNumeroConta(), new DepositoInicial(valorDepositoInicial));
            return novaConta;
        }
    }
}
