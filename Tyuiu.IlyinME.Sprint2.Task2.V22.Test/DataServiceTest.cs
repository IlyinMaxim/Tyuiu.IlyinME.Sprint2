using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint2.Task2.V22.Lib; 

namespace Tyuiu.IlyinME.Sprint2.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
