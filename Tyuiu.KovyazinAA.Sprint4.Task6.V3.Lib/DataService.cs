﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KovyazinAA.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, x => x.Length < 6);
            return result.Length;
        }
    }
}
