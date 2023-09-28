using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VasilevAA.Sprint2.Task4.V1.Lib
{
    public class DataService : ISprint2Task4V1
    {
        public double Calculate(double x, double y)
        {
            if (x < y)
            {
                return Math.Round((x + 3) / y, 3);
            }
            else
            {
                return Math.Round((x + 1) / (x - 2), 3);
            }
        }
    }
}
