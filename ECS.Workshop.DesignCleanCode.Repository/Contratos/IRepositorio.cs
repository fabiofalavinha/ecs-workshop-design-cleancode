using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Repository.Contratos
{
    public interface IRepositorio<TipoDado>
    {
        TipoDado Criar(TipoDado registro);
        TipoDado Atualizar(TipoDado registro);
        bool Deletar(TipoDado registro);
        TipoDado[] BuscarTodos();
    }
}
