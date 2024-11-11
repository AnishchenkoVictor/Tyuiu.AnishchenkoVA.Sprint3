using Tyuiu.AnishchenkoVA.Sprint3.Task6.V14.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = 7;
            int end = 16;
            
            int res = ds.GetSumTheDivisors(start, end);

            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}