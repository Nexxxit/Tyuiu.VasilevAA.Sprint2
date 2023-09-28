using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint2.Task3.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x;

            Console.WriteLine("Введите х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
