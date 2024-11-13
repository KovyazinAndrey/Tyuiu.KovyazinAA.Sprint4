using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KovyazinAA.Sprint4.Task7.V2.Lib
{
    public class DataService : ISprint4Task7V2
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] nums = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    if (nums[i, j] % 2 != 0) 
                    {
                        sum += nums[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
