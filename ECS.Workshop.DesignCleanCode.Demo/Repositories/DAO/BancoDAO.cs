using ECS.Workshop.DesignCleanCode.Demo.Domains;
using System;
using System.Collections.Generic;


namespace ECS.Workshop.DesignCleanCode.Demo.Repositories.DAO
{
    public class BancoDAO
    {
        private static BancoDAO instance;
        private readonly IDictionary<Guid, Banco> dados = new Dictionary<Guid, Banco>();

        public static BancoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BancoDAO();
                }

                return instance;
            }
        }

        public void Registro(Banco banco)
        {
            if(dados.TryGetValue(banco.Agencia.Numero, out Banco result))
            {
                System.Windows.Forms.MessageBox.Show($"Não foi possivel registrar o banco.Agência já existente: N°{ banco.Agencia.Numero}");
            }

            dados.Add(banco.Agencia.Numero, banco);
        }
    }
}
