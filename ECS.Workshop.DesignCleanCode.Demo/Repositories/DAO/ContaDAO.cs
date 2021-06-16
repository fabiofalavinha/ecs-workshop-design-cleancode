using ECS.Workshop.DesignCleanCode.Demo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Repositories.DAO
{
    public class ContaDAO
    {
        private static ContaDAO instance;
        private readonly IDictionary<Guid, Conta> dados = new Dictionary<Guid, Conta>();

        public static ContaDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContaDAO();
                }

                return instance;
            }
        }

        public void Registro(Conta conta)
        {
            if (dados.TryGetValue(conta.NumeroConta.Valor, out Conta result))
            {
                System.Windows.Forms.MessageBox.Show($"Conta já existente. N° ${result.NumeroConta.Valor}");
            }

            dados.Add(conta.NumeroConta.Valor, conta);
        }

        public void Atualizar(Conta conta)
        {
            if (!dados.TryGetValue(conta.NumeroConta.Valor, out Conta result))
            {
                System.Windows.Forms.MessageBox.Show($"Conta não encontrada. N° ${result.NumeroConta.Valor}");
            }

            dados[conta.NumeroConta.Valor] = conta;
        }
    }
}
