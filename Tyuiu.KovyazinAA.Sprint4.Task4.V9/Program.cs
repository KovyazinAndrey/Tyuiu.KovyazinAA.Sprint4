using Tyuiu.KovyazinAA.Sprint4.Task4.V9.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы ( ввод с клавиатуры )                           *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8. Найдите сумму четных     *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите количество строк в массиве:                                     *");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("* Введите количество столбцов в массиве:                                  *");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] nums = new int[rows, cols];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    nums[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\nМассив:");
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    Console.Write($"{nums[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(nums));
        }
    }
}
