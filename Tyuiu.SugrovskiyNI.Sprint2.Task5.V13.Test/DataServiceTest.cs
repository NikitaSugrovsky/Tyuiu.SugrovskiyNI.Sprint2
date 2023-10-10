using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint2.Task5.V2.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Янвврь", ds.FindMonthSeason(1));
            Assert.AreEqual("Февраль", ds.FindMonthSeason(2));
            Assert.AreEqual("Март", ds.FindMonthSeason(3));
            Assert.AreEqual("Апрель", ds.FindMonthSeason(4));
            Assert.AreEqual("Май", ds.FindMonthSeason(5));
            Assert.AreEqual("Июнь", ds.FindMonthSeason(6));
            Assert.AreEqual("Июль", ds.FindMonthSeason(7));
            Assert.AreEqual("Август", ds.FindMonthSeason(8));
            Assert.AreEqual("Сентябрь", ds.FindMonthSeason(9));
            Assert.AreEqual("Октябрь", ds.FindMonthSeason(10));
            Assert.AreEqual("Ноябрь", ds.FindMonthSeason(11));
            Assert.AreEqual("Декабрь", ds.FindMonthSeason(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(13);
            });
            }
        }
    }

