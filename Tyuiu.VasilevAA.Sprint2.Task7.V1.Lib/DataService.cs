using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VasilevAA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if((y <= x) && (y >= -x) && (Math.Pow(x,2) + Math.Pow(y,2) <= 1) && y >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
