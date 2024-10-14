using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SimonovMA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inParabola = (x >= -1 && x <= 1) && (y >= 0 && y <= (1 - x * x));
            bool inCircle = (x * x + (y - 1) * (y - 1) <= 1);

            return inParabola && inCircle;
        }
    }
}
