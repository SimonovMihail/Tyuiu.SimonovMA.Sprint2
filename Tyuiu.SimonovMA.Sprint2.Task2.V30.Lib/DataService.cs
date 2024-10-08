using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SimonovMA.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x >= 3 && x <= 5) && (y >= 3 && y <= 4)) || ((x >= 9 && x <= 12) && (y >= 3 && y <= 4)) ||
                    ((x >= 3 && x <= 12) && (y >= 5 && y <= 7)) || ((x >= 3 && x <= 12) && y == 11))
            {
                return true;
            }
            else
            {
                if ((x == 2 && (y >= 4 && y <= 6)) || (x == 13 && (y >= 6 && y <= 7)) ||
                        (x == 6 && (y >= 8 && y <= 10)) || (y == 12 && (x >= 7 && x <= 10)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
