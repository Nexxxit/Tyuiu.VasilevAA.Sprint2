using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VasilevAA.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return Math.Round(x - 12 * x + Math.Cos(x), 3);
            }
            else if (x == 0)
            {
                return Math.Round(x - (1 / x), 3);
            }
            else if (x > -6 && x < 0)
            {
                return Math.Round(x * x * x * x * x + 10 * x - (1 / Math.Sqrt(x + 3)), 3);
            }
            else if (x < -6)
            {
                return Math.Round(x + 10 * x - (1 / x * x * x * x), 3);
            }
            else
            {
                return 0;
            }
        }
    }
}
