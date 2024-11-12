using Tyuiu.AnishchenkoVA.Sprint3.Task7.V21.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*        2*cos(x) + 2                                                     *");
            Console.WriteLine("* F(x) = ------------  + cos(x) - 5*x + 3 (произвести табулирование)      *");
            Console.WriteLine("*          2*x - 1                                                        *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1.                                 *");
            Console.WriteLine("* Произвести проверку деления на 0. При делении на ноль вернуть 0.        *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int end = 5;

            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);

            int len = ds.GetMassFunction(start, end).Length;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |   F(x)     |");
            Console.WriteLine("+----------+------------+");

            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}    |", start, res[i]);
                start++;
            }
            Console.WriteLine("+----------+------------+");
            Console.ReadKey();
        }
    }
}
