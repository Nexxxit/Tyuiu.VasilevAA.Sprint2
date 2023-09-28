using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VasilevAA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool res1, res2, res3, res4, res5, res6;

            res1 = (a > b) | (c < d);
            res2 = (a + 2 > b) & (c < d);
            res3 = (a > b) || (c < d);
            res4 = (a + 2 > b) && (c < d);
            res5 = !(res2);
            res6 = (b > a) ^ (c < d);

            bool[] array = new bool[] { res1, res2, res3, res4, res5, res6 };

            return array;
        }
    }
}
