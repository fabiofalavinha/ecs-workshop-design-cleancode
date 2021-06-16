using ECS.Workshop.DesignCleanCode.Demo.Dominio.Contratos;
using ECS.Workshop.DesignCleanCode.Repository.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECS.Workshop.DesignCleanCode.Repository.Repositorios
{
    public class Repositorio<TipoDado> : IRepositorio<TipoDado>
        where TipoDado : IEntidadePadrao
    {
        protected virtual List<TipoDado> Registros { get; set; }
        
        public Repositorio()
        {
            Registros = new List<TipoDado>();
        }
        
        public TipoDado Atualizar(TipoDado registro)
        {
            int indice = Registros.FindIndex(q => q.Id == registro.Id);
            Registros[indice] = registro;

            return registro;
        }

        public TipoDado[] BuscarTodos()
        {
            return Registros.ToArray();
        }

        public TipoDado Criar(TipoDado registro)
        {
            Registros.Add(registro);
            return registro;
        }

        public bool Deletar(TipoDado registro)
        {
            int indice = Registros.FindIndex(q => q.Id == registro.Id);
            Registros.RemoveAt(indice);

            return true;
        }
    }
}
