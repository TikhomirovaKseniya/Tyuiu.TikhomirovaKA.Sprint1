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

            double number = 243.3056;
            bool res = ds.ZeroCheck(number);
            Assert.AreEqual(true, res);
        }
    }
}
