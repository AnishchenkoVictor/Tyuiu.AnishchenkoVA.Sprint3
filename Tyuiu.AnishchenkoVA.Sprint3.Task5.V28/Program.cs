using Tyuiu.AnishchenkoVA.Sprint3.Task5.V28.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint3.Task5.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                  x                                                      *");
            Console.WriteLine("*      3    12    k                                                       *");
            Console.WriteLine("*  y = E    E   ------ ,      при x = 2                                   *");
            Console.WriteLine("*     i=1  k=1  sin(k)                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 12;

            Console.WriteLine("Переменная x = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + start1);
            Console.WriteLine("Конец шага первой суммы ряда = " + end1);
            Console.WriteLine("Старт шага второй суммы ряда = " + start2);
            Console.WriteLine("Конец шага второй суммы ряда = " + end2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, start1, start2, end1, end2));
            Console.ReadKey();
        }
    }
}
