using System;
using Tyuiu.SimonovMA.Sprint2.Task7.V3.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), true);
        }
    }
}