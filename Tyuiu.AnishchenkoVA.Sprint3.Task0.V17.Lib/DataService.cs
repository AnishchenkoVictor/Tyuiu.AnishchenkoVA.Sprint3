using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;

            if (startValue > stopValue)
            {
                throw new ArgumentException("startValue должен быть меньше или равен stopValue.");
            }

            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Cos(i) * 0.5;
            }

            return Math.Round(sumSeries,3);
        }
    }
}
