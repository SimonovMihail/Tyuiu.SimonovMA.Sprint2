using System;
using Tyuiu.SimonovMA.Sprint2.Task0.V23.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, после-  *");
            Console.WriteLine("* довательность не должна нарушаться) и арифметических выражений, которая *");
            Console.WriteLine("* вернёт логическую последовательность(массив): (True, False, True, True, *");
            Console.WriteLine("* False, True), при x = 105, y = 795.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 105   y = 795                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] barrage = new bool[6];

            barrage = ds.GetCompareOperations(105, 795);
            string barrage_string = string.Join(", ", barrage);

            Console.WriteLine(barrage_string);
            Console.ReadKey();
        }
    }
}
