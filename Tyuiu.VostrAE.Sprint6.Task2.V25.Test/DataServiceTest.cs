using Tyuiu.VostrAE.Sprint6.Task2.V25.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task2.V25.Test
{
    [TestClass]
    public sealed class Test1
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
