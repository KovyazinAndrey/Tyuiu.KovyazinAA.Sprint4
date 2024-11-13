using Tyuiu.KovyazinAA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] nums = { { -9, 7, -6, 4, -6 }, { 5, -8, 3, -7, 5 }, { 6, -5, -6, 4, 8 }, { 6, -8, 4, 7, -8 }, { 6, -7, -5, -4, 6 } };
            int[,] wait = { { -9, 1, -6, 1, -6 }, { 1, -8, 1, -7, 1 }, { 1, -5, -6, 1, 1 }, { 1, -8, 1, 1, -8 }, { 1, -7, -5, -4, 1 } };
            int[,] result = ds.Calculate(nums);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}