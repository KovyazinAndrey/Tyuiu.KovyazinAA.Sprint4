﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KovyazinAA.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            int c = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    c *= array[i];
                }
            }
            return c;
        }
    }
}
