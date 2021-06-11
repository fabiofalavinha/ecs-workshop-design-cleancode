using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Exceptions
{
    public class ContaException : Exception
    {
        public ContaException(string message) : base(message)
        {

        }

    }
}
