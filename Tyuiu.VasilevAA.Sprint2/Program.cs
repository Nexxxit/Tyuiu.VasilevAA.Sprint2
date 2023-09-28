using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint2.Task0.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 233;
            int b = 122;

            bool[] array = new bool[] { };
            array = ds.GetCompareOperations(a, b);

            foreach ( bool i in array )
            {
                Console.Write( i  + " ");
            }

            
            Console.ReadKey();
        }
    }
}
