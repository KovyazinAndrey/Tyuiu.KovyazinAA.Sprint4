using Tyuiu.KovyazinAA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы ( генератор случайных чисел )                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -9 до 8. Заменить положительные    *");
            Console.WriteLine("* элементы на 1.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите количество строк массива                                        *");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите количество столбцов массива                                     *");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] nums = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = rnd.Next(-9, 8);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            nums = ds.Calculate(nums);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
