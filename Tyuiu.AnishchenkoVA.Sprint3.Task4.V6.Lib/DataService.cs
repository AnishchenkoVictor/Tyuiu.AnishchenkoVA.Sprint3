using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    res = res + (i / (Math.Cos(i) - Math.Sin(i)));
                }
            }
            return Math.Round(res,3);
        }
    }
}
