using Tyuiu.TikhomirovaKA.Sprint1.Task4.V5.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 8;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.128, res);
        }
    }
}
