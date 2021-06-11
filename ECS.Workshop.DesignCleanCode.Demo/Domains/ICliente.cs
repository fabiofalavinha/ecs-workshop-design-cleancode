using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public interface ICliente
    {
        int Id { get; set; }
        string Nome { get; set; }

    }
}
