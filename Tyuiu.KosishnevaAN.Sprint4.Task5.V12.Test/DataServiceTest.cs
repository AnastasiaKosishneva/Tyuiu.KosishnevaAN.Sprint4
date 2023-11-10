using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint4.Task5.V12.Lib;

namespace Tyuiu.KosishnevaAN.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {  { -1, 1, 3, 2, 2 },
                                           { 2, 3, 2, 3, 2 },
                                           { 2, 3, 2, 2, 3 },
                                           { 2, 3, 2, 2, 2 },
                                           { 2, 2, 2, 2, 2 }, };
            int res = ds.Calculate(mas2);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
