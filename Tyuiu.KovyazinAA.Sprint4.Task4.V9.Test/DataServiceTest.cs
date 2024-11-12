using Tyuiu.KovyazinAA.Sprint4.Task4.V9.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] nums = { { 3, 7, 3, 1, 5 },
                            { 6, 3, 2, 1, 2 },
                            { 1, 3, 2, 8, 1 },
                            { 5, 8, 1, 5, 1 },
                            { 3, 3, 4, 4, 6 } };
            int res = ds.Calculate(nums);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}