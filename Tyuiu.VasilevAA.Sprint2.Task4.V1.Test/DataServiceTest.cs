using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint2.Task4.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            double x = 9, y = 4;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.429, res);
        }
    }
}
