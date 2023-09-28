using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Tyuiu.VasilevAA.Sprint2.Task0.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            int a = 233;
            int b = 122;
            bool[] bools = new bool[] {true, false, true, false, true, false };
     
            var res = ds.GetCompareOperations(a, b);
            CollectionAssert.AreEqual(bools, res);
        }
    }
}
