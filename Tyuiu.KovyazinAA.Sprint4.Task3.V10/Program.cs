using Tyuiu.KovyazinAA.Sprint4.Task3.V10.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ковязин А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы ( статический ввод )                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Ковязин Андрей Александрович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент в третьей строке массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив:                                                                 *");
            Console.WriteLine("* ( 5, 7, 6, 6, 5,                                                        *");
            Console.WriteLine("*   5, 5, 5, 4, 6,                                                        *");
            Console.WriteLine("*   8, 5, 7, 4, 7,                                                        *");
            Console.WriteLine("*   7, 6, 7, 4, 7,                                                        *");
            Console.WriteLine("*   5, 8, 7, 8, 8 )                                                       *");
            int[,] nums = { { 5, 7, 6, 6, 5 }, { 5, 5, 5, 4, 6 }, { 8, 5, 7, 4, 7 }, { 7, 6, 7, 4, 7 }, { 5, 8, 7, 8, 8 } };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(nums));
        }
    }
}
