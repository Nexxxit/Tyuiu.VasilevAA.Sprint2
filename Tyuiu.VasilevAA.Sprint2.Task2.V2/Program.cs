using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint2.Task2.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x, y;

            Console.WriteLine("Введите х: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
