using Tyuiu.KovyazinAA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetMultOddArrEl(nums);
            int wait = 138915;
            Assert.AreEqual(wait, res);
        }
    }
}