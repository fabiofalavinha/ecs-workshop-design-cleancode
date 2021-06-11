using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class TransacaoFinanceira
    {
        public Guid Id { get; set; }
        public DateTime DataTransacao { get; set; }
        public IConta ContaOrigem { get; set; }
        public IConta ContaDestino { get; set; }
        public double Valor { get; set; }


        public TransacaoFinanceira DepositoInicial(IConta contaDestino, double valor)
        {
            Id = Guid.NewGuid();
            DataTransacao = DateTime.Now;
            ContaDestino = contaDestino;
            Valor = valor;
            return this;
        }

        public TransacaoFinanceira Transferencia(IConta contaOrigem, IConta contaDestino, double valor)
        {
            Id = Guid.NewGuid();
            DataTransacao = DateTime.Now;
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            Valor = valor;
            return this;
        }



    }
}
