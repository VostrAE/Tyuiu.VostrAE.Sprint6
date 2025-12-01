using Tyuiu.VostrAE.Sprint6.Task0.V9.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res =ds.Calculate(1);
            double wait = 0;
            Assert.AreEqual(res,wait);
        }
    }
}
