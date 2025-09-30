using Tyuiu.TikhomirovaKA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Hello world";
            var res = ds.MoveLetterToEnd(value);
            Assert.AreEqual("elloH orldw ", res);
        }
    }
}
