using System;
using Tyuiu.SimonovMA.Sprint2.Task4.V16.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double expected = 1.25;
            Assert.AreEqual(expected, ds.Calculate(x, y));
        }

        [TestMethod]
        public void CheckCondition2()
        {
            DataService ds = new DataService();
            double x = 400;
            double y = 53;
            double expected = 53;
            Assert.AreEqual(expected, ds.Calculate(x, y));
        }

    }
}