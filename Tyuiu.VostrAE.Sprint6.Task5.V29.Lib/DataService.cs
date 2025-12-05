using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VostrAE.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            string[] Lines = File.ReadAllLines(path);
            len = Lines.Length;
            double[] numsArray = new double[Lines.Length];
            for (int i = 0; i < Lines.Length; i++)
            {
                numsArray[i] = Convert.ToDouble(Lines[i]);
            }
            numsArray = numsArray.Where(val => val >= 10).ToArray();
            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = Math.Round(numsArray[i], 3);
            }
            return numsArray;
        }
    }
}
