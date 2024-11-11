using Tyuiu.AnishchenkoVA.Sprint3.Task2.V21.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double x = 1.5;
            int start = 1;
            int end = 2;

            double res = ds.GetSumSeries(x, start, end);

            double wait = 0.294;
            Assert.AreEqual(wait, res);
        }
    }
}