using Tyuiu.AnishchenkoVA.Sprint3.Task1.V11.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task1.V11
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
            Console.WriteLine("* Написать программу используя цикл while,                                *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле, при a=0,75              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.75;
            int start = 1;
            int end = 14;

            Console.WriteLine("Переменная а = " + a);
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение по форму p = " + ds.GetMultiplySeries(a, start, end));
            Console.ReadKey();
        }
    }
}
