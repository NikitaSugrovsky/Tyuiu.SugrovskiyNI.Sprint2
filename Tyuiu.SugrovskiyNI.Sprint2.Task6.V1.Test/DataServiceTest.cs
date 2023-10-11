using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint2.Task6.V1.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Январь", ds.FindMonthDaysCount(1));
            Assert.AreEqual("Февраль", ds.FindMonthDaysCount(2));
            Assert.AreEqual("Март", ds.FindMonthDaysCount(3));
            Assert.AreEqual("Апрель", ds.FindMonthDaysCount(4));
            Assert.AreEqual("Май", ds.FindMonthDaysCount(5));
            Assert.AreEqual("Июнь", ds.FindMonthDaysCount(6));
            Assert.AreEqual("Июль", ds.FindMonthDaysCount(7));
            Assert.AreEqual("Август", ds.FindMonthDaysCount(8));
            Assert.AreEqual("Сентябрь", ds.FindMonthDaysCount(9));
            Assert.AreEqual("Октябрь", ds.FindMonthDaysCount(10));
            Assert.AreEqual("Ноябрь", ds.FindMonthDaysCount(11));
            Assert.AreEqual("Декабрь", ds.FindMonthDaysCount(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(13);
            });
        }
    }
}
