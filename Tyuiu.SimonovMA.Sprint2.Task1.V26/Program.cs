using System;
using Tyuiu.SimonovMA.Sprint2.Task1.V26.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, после-  *");
            Console.WriteLine("* довательность можно чередовать, но использовать один раз в выражении) и *");
            Console.WriteLine("* логических операции (|, &, ||, &&, !, ^, последовательность операций не *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернёт    *");
            Console.WriteLine("* логическую последовательность(массив): (True, True, True, False, True,  *");
            Console.WriteLine("* False), при a = 654, b = 671, c = 874, d = 137                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 654   b = 671   c = 874   d = 137                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;

            bool[] beeg = new bool[6];
            beeg = ds.GetLogicOperations(a, b, c, d);

            string beeg_string = string.Join(", ", beeg);

            Console.WriteLine(beeg_string);
            Console.ReadKey();
        }
    }
}
