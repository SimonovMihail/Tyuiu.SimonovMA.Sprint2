using System;
using Tyuiu.SimonovMA.Sprint2.Task3.V2.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            Assert.AreEqual(-44.654, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            Assert.AreEqual(1.5, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCondition3()
        {
            DataService ds = new DataService();
            double x = -2;
            Assert.AreEqual(-53, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCondition4()
        {
            DataService ds = new DataService();
            double x = -13;
            Assert.AreEqual(-143, ds.Calculate(x));
        }

    }
}