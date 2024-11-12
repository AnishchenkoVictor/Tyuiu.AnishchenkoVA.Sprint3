using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {

                if (2 * i - 1 == 0)
                {
                    res[count] = 0;
                }

                double y = (2 * Math.Cos(i) + 2)/(2 * i - 1) + Math.Cos(i) - 5*i + 3;
                res[count] = Math.Round(y, 2);
                count++;
            }
            return res;
        }
    }
}
