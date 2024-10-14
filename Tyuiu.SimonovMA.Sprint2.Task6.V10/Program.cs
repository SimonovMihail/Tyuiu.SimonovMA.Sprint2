using System;
using Tyuiu.SimonovMA.Sprint2.Task6.V10.Lib;

namespace Tyuiu.SimonovMA.Sprint2.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами g (год), *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m           *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g, m, n;

            Console.WriteLine("Введите год:");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDateOfPreviousDay(g, m, n));
            Console.ReadKey();
        }
    }
}
