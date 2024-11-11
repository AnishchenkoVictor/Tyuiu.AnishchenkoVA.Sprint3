using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res = res + Math.Pow((1 / (Math.Sin(startValue) + 2* Math.Pow(value, startValue))) , startValue);
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(res, 3);
        }
    }
}
