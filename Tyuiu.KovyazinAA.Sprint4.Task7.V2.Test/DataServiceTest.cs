using Tyuiu.KovyazinAA.Sprint4.Task7.V2.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int r = 3;
            int c = 4;
            int[,] nums = new int[r,c];

            string str = "597643158942";
            int res = ds.Calculate(r,c,str);
            int wait = 39;
            Assert.AreEqual(wait,res);
        }
    }
}