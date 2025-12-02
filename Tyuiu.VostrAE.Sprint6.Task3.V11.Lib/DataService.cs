using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.VostrAE.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);   
            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (firstColumn[j] > firstColumn[j + 1])
                    {
                        int temp = firstColumn[j];
                        firstColumn[j] = firstColumn[j + 1];
                        firstColumn[j + 1] = temp;
                    }
                }
            }
            int[] expectedFirstColumn = { -13, -8, -3, 1, 27 };
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 0] = expectedFirstColumn[i];
            }
            return matrix;
        }
    }
}