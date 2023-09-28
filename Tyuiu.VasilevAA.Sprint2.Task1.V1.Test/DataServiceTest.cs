using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint2.Task1.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] bools = new bool[] { true, false, true, false, true, false };
            var res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(bools, res);
        }
    }
}
