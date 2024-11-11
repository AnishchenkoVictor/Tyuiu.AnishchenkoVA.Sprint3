using Tyuiu.AnishchenkoVA.Sprint3.Task2.V21.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while,                           *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при х = 1,5                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 1.5;
            int start = 1;
            int end = 2;

            Console.WriteLine("Переменная x = " + x);
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда S = " + ds.GetSumSeries(x, start, end));
            Console.ReadKey();
        }
    }
}
