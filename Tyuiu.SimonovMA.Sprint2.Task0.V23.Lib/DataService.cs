using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SimonovMA.Sprint2.Task0.V23.Lib
{
    public class DataService : ISprint2Task0V23
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6]; //Создаёт массив
            result[0] = (x + y) == 900;
            result[1] = (x - y) == 690;
            result[2] = (x * 2) < y;
            result[3] = (y / 7) > x;
            result[4] = (y <= x);
            result[5] = (y >= 795);

            return result;
        }
    }
}
