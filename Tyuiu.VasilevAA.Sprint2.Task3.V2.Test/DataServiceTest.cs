using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint2.Task3.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds  = new DataService();

            double x = 5;

            var res = ds.Calculate(x);
            Assert.AreEqual(-54.716, res);
        }
    }
}
