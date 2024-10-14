using System;
using Tyuiu.SimonovMA.Sprint2.Task6.V10.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFromTheFirstDate()
        {
            DataService ds = new DataService();
            string FromFirstMarch = ds.FindDateOfPreviousDay(2024, 3, 1);
            Assert.AreEqual("28.02.2024", FromFirstMarch);
        }

        [TestMethod]
        public void CheckFromTheFirstDecember()
        {
            DataService ds = new DataService();
            string FromFirstJanuary = ds.FindDateOfPreviousDay(2024, 1, 1);
            Assert.AreEqual("31.12.2023", FromFirstJanuary);
        }

    }
}