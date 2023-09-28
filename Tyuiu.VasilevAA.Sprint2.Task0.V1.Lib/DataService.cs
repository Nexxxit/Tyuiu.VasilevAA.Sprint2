using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VasilevAA.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int a, int b)
        {
            bool res1, res2, res3, res4, res5, res6;

            res1 = a == b + 111;
            res2 = a - 111 != b;
            res3 = a - 115 < b;
            res4 = b > a;
            res5 = b <= a;
            res6 = b >= a;

            bool[] array = new bool[] {res1, res2, res3, res4, res5, res6 };
            
            return array;
        }

    }
}
