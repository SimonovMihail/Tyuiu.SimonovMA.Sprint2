using System;
using Tyuiu.SimonovMA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void mmmm_i_love_methods()
        {
            DataService ds = new DataService();
            Assert.AreEqual("�����������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(2));
            Assert.AreEqual("�����", ds.FindDayName(3));
            Assert.AreEqual("�������", ds.FindDayName(4));
            Assert.AreEqual("�������", ds.FindDayName(5));
            Assert.AreEqual("�������", ds.FindDayName(6));
            Assert.AreEqual("�����������", ds.FindDayName(7));
            Assert.AreEqual("�������� ���� ������", ds.FindDayName(4365));
        }
    }
}