using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.VostrAE.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ValueArray;
            int len = (stopValue - startValue) + 1;
            ValueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) - 2 == 0)
                {
                    ValueArray[count] = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2;
                    ValueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return ValueArray;
        }
    }
}
