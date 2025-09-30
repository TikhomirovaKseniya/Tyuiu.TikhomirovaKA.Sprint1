using Tyuiu.TikhomirovaKA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.148, res);
        }
    }
}
