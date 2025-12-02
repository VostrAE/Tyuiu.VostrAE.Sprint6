using Tyuiu.VostrAE.Sprint6.Task2.V25.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(stopStep));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-25-1 Вострых Александр Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExit.BackColor = Color.Red;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Green;
        }
    }
}
