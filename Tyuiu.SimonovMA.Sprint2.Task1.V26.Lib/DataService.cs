using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SimonovMA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // Для справки:
            // a = 654, b = 671, c = 874, d = 137
            // Сравнения: ==, !=, <, >, <=, >= (один раз использовать!!)
            // Логика: |, &, ||, &&, !, ^ (не нарушать последовательность)
            // Нужно: True, True, True, False, True, False

            bool[] answer = new bool[6];

            answer[0] = (a < b) && (c > d);
            answer[1] = (a == b) || !(c == d);
            answer[2] = (a != b) ^ (c == d);
            answer[3] = (a != b) == (c < d);
            answer[4] = (b <= a) != (d <= c);
            answer[5] = !(a != b) || (c < d);

            return answer;
        }
    }
}
