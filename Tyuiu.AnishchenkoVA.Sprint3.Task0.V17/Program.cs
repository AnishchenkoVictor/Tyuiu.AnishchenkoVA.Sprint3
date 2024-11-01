using Tyuiu.AnishchenkoVA.Sprint3.Task0.V17.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for,                                  *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*     10         1                                                        *");
            Console.WriteLine("* S = E cos(i) * -                                                        *");
            Console.WriteLine("*    i=1         2                                                        *");

            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма по формуле = " + ds.GetSumSeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
