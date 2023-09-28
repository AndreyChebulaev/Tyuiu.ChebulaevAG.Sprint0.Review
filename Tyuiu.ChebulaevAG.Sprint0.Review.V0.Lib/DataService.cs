using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ChebulaevAG.Sprint0.Review.V0.Lib
{
    public class DataService
    {
        public int Calc(int x, int y, int z)
        {
            int result = (x + y + z) * 5;
            return result;
        }
    }
}
