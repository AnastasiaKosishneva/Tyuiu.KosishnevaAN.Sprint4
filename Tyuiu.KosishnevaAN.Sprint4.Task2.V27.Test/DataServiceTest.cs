using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint4.Task2.V27.Lib;
namespace Tyuiu.KosishnevaAN.Sprint4.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 14;
            Assert.AreEqual(wait, res);

        }
    }
}
