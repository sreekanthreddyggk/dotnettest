using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.WiTronix.DataAccess
{
    public class CaluclateDataAccess
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Sub(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Div(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
