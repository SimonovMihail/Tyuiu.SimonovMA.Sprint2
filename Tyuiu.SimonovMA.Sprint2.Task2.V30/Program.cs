using System;
using Tyuiu.SimonovMA.Sprint2.Task2.V30.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X, Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            int y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
