using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint2.Task0.V6.Lib; 

namespace Tyuiu.SugrovskiyNI.Sprint2.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
