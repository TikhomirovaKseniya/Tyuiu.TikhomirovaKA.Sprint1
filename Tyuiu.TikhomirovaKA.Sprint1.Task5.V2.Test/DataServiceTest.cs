using Tyuiu.TikhomirovaKA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 451;
            var res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(233, res);
        }
    }
}
