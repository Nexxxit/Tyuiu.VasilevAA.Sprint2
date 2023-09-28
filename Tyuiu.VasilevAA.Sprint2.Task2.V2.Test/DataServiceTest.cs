using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint2.Task2.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            int x = 9, y = 6;

            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
