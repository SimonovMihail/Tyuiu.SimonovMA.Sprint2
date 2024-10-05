using System;
using Tyuiu.SimonovMA.Sprint2.Task1.V26.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;

            bool[] result = new bool[6];

            result = ds.GetLogicOperations(a, b, c, d);

            string string_result = string.Join(", ", result);
            Assert.AreEqual("True, True, True, False, True, False", string_result);
        }
    }
}