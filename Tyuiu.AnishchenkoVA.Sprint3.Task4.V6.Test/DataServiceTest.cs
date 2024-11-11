using Tyuiu.AnishchenkoVA.Sprint3.Task4.V6.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            double res = ds.Calculate(start, end);

            double wait = 8.995;
            Assert.AreEqual(wait, res);
        }
    }
}