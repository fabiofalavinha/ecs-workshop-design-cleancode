using ECS.Workshop.DesignCleanCode.Demo.Domains;
using ECS.Workshop.DesignCleanCode.Demo.Repositories.DAO;

namespace ECS.Workshop.DesignCleanCode.Demo.Repositories
{
    public class BancoRepository : IBancoRepository
    {
        public void Registro(Banco banco)
        {
            BancoDAO.Instance.Registro(banco);
        }

        public void RegistrarConta(Conta conta)
        {
            ContaDAO.Instance.Registro(conta);
        }

        public void Depositar(Conta conta, Amount amount)
        {
            conta.Depositar(amount);
            ContaDAO.Instance.Atualizar(conta);
        }
    }
}
