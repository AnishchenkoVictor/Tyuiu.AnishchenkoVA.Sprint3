using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            while (startValue <= stopValue)
            {
                res = res * (Math.Pow(value, startValue) + 0.5);
                startValue++;
            }

            return res;
        }
    }
}
