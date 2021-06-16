using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains
{
    public class Amount
    {
        public static readonly Amount One = FromInt(1);
        public static readonly Amount Zero = FromInt(0);

        public int Value { get; private set; }

        public decimal ToDecimal()
        {
            return Convert.ToInt64(Value);
        }

        public Amount(int value)
        {
            Value = value;
        }

        public bool IsNegativeOrZero()
        {
            return Value <= 0;
        }

        public static Amount FromInt(int value)
        {
            return new Amount(value);
        }
    }
}
