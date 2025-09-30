﻿using Tyuiu.TikhomirovaKA.Sprint1.Task1.V9.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}
