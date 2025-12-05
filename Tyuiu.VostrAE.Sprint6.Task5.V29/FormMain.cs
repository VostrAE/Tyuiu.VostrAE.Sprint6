using Tyuiu.VostrAE.Sprint6.Task5.V29.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            DataGridViewNums.ColumnCount = 2;
            DataGridViewNums.Columns[0].Width = 20;
            DataGridViewNums.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                DataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-25-1 Вострых Александр Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }
    }
}
