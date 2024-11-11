using Tyuiu.KovyazinAA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы ( статический ввод )                           *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] nums = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            Console.WriteLine("* Исходный массив:                                                        *");
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.GetMultOddArrEl(nums);
            Console.WriteLine(res);
        }
    }
}
