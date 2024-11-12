using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KovyazinAA.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            int Maxnum = 0;
            
            for (int j = 0; j < cols; j++)
            {
                if (array[2, j] >= Maxnum)
                {
                    Maxnum = array[2, j];
                }
            }
            return Maxnum;
        }
    }
}
