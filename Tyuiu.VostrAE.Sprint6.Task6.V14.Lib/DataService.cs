using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.VostrAE.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            bool firstWord = true;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string word in line.Split(' '))
                    {
                        if (!string.IsNullOrEmpty(word) && word.Contains("z"))
                        {
                            if (!firstWord)
                                resStr += " ";
                            resStr += word;
                            firstWord = false;
                        }
                    }
                }
            }

            return resStr;
        }
    }
}
