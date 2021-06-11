using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public interface ITransacaoFinanceira
    {
        Guid Id { get; set; }
        DateTime DataTransacao { get; set; }
        IConta ContaOrigem { get; set; }
        IConta ContaDestino { get; set; }
        double Valor { get; set; }

        TransacaoFinanceira Creditar(IConta contaDestino, double valor);
        TransacaoFinanceira Creditar(IConta contaOrigem, IConta contaDestino, double valor);
        TransacaoFinanceira Debitar(IConta contaOrigem, IConta contaDestino, double valor);
    }
}
