using Tyuiu.TikhomirovaKA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double number = 243.356;
            bool res = ds.ZeroCheck(number);
            Assert.AreEqual(false, res);

            double number2 = 2403.356;
            bool res2 = ds.ZeroCheck(number2);
            Assert.AreEqual(true, res2);
        }
    }
}
