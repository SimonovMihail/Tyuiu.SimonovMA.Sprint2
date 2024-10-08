using System;
using Tyuiu.SimonovMA.Sprint2.Task2.V30.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void mmm_testiki()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}