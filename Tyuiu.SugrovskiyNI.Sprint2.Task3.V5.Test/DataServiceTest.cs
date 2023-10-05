using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint2.Task3.V5.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.1;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = -5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -6;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }

    }
}
