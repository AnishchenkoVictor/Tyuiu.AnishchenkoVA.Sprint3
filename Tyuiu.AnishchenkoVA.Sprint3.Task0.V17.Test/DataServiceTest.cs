using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Tyuiu.AnishchenkoVA.Sprint3.Task0.V17.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int Ib = 1;
            int Ie = 10;
            double kk = -0.709;
            double res = ds.GetSumSeries(Ib, Ie);
            Assert.AreEqual(kk, res);
        }
    }
}