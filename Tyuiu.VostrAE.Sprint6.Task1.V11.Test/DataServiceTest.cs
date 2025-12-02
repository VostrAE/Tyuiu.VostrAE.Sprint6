using Tyuiu.VostrAE.Sprint6.Task1.V11.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);
            Console.WriteLine(res);
        }
    }
}
