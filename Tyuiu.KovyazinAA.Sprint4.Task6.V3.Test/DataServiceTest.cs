using Tyuiu.KovyazinAA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.KovyazinAA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] months = { "������", "�������", "����", "������", "���", "����", "����", "������", "��������", "�������", "������", "�������" };
            int res = ds.Calculate(months);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}