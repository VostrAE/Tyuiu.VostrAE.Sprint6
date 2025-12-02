using System.Text;
using System.Windows.Forms;
using Tyuiu.VostrAE.Sprint6.Task1.V11.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task1.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-25-1 Вострых Александр Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxExit_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEnterStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnterEnd_Click(object sender, EventArgs e)
        {

        }
        private void buttonEnterEnd_Click_1(object sender, EventArgs e)
        {

        }
        private void textBoxExit_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxEnterStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxEnterStart.Text);
                int stopStep = Convert.ToInt32(textBoxEnterEnd.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxExit.Text = "";
                textBoxExit.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxExit.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxExit.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("| {0,5:d}    |  {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxExit.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxExit.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
