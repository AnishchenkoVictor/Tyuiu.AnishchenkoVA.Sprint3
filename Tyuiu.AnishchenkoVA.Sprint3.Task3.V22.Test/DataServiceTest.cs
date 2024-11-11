using Tyuiu.AnishchenkoVA.Sprint3.Task3.V22.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string str = "tbtbbb dsfbg bbg";
            char c = 'b';

            int res = ds.GetMaxCharCount(str, c);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}