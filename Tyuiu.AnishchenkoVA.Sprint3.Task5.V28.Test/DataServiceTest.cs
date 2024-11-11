using Tyuiu.AnishchenkoVA.Sprint3.Task5.V28.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int start1 = 1;
            int end1 = 2;
            int start2 = 1;
            int end2 = 2;

            double res = ds.GetSumSumSeries(x, start1, start2, end1, end2);
            double wait = 11.175;

            Assert.AreEqual(wait, res);
        }
    }
}