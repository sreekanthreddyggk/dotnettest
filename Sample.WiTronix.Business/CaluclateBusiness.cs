using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.WiTronix.DataAccess;

namespace Sample.WiTronix.Business
{
    public class CaluclateBusiness
    {
        private CaluclateDataAccess _caluclateDataAccess = null;
        public CaluclateBusiness()
        {
            _caluclateDataAccess = new CaluclateDataAccess();
        }
        public int Add(int value1, int value2)
        {
            return _caluclateDataAccess.Add(value1, value2);
        }

        public int Sub(int value1, int value2)
        {
            return _caluclateDataAccess.Sub(value1, value2);
        }

        public int Multiply(int value1, int value2)
        {
            return _caluclateDataAccess.Multiply(value1, value2);
        }

        public int Div(int value1, int value2)
        {
            return _caluclateDataAccess.Div(value1, value2);
        }
    }
}
