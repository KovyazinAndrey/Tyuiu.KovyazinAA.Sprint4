using Tyuiu.KovyazinAA.Sprint4.Task2.V15.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2 };
            int res = ds.Calculate(nums);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}