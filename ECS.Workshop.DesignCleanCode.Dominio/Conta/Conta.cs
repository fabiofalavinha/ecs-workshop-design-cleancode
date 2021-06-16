using ECS.Workshop.DesignCleanCode.Demo.Dominio;
using ECS.Workshop.DesignCleanCode.Demo.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Dominio.Conta
{
    public abstract class Conta : IEntidadePadrao
    {
        private static int ControleNumeroConta { get; set; }

        public Conta()
        {
            ControleNumeroConta++;
            Numero = "";
        }

        public string Numero { get; set; }
        public Cliente[] Clientes { get; set; }
        public TaxaAdministrativa TaxaAdministrativa { get; set; }
        public decimal Saldo { get; set; }
        public int Id { get; set; }
    }
}
