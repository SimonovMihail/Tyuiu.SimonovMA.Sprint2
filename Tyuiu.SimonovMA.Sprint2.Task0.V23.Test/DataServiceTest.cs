using System;
using Tyuiu.SimonovMA.Sprint2.Task0.V23.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 795;

            bool[] result = new bool[6];
            result = ds.GetCompareOperations(x, y);
            string string_result = string.Join(", ", result);
            Assert.AreEqual("True, False, True, True, False, True", string_result);
        }
    }
}