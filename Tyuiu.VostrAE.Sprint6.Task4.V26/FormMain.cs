using Tyuiu.VostrAE.Sprint6.Task4.V26.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task4.V26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxOut.Text = "";
                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOut.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask4V26.txt");
                File.WriteAllText(path, textBoxOut.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?","Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                } 
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб-25-1 Вострых Александр Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
