using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SimonovMA.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new ArgumentException("Неверный номер месяца.")
            };

            if (n == 1)
            {
                m = m - 1;

                if (m == 0)
                {
                    m = 12;
                    g = g - 1;
                }

                daysInMonth = m switch
                {
                    1 => 31,
                    2 => 28,
                    3 => 31,
                    4 => 30,
                    5 => 31,
                    6 => 30,
                    7 => 31,
                    8 => 31,
                    9 => 30,
                    10 => 31,
                    11 => 30,
                    12 => 31,
                    _ => throw new ArgumentException("Неверный номер месяца.")
                };

                n = daysInMonth;
            }
            else
            {
                n = n - 1;
            }

            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}
