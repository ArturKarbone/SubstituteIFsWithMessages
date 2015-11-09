using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteIFsWithMessages
{
    public static class BoolExtensions
    {
        public static void IfTrue(this bool value, Action action)
        {
            if (value)
            {
                action();
            }
        }

        public static void IfFalse(this bool value, Action action)
        {
            if (!value)
            {
                action();
            }
        }
    }
}
