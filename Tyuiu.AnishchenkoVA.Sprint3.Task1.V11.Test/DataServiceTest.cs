using Tyuiu.AnishchenkoVA.Sprint3.Task1.V11.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 0.75;    
            int start = 1;
            int end = 2;

            double res = ds.GetMultiplySeries(a, start, end);
            double wait = 1.328125;
            Assert.AreEqual(wait, res);
        }
    }
}