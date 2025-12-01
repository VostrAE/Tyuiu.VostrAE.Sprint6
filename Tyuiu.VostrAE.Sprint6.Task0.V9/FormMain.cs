using System.Windows.Forms;
using Tyuiu.VostrAE.Sprint6.Task0.V9.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.VostrAE.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-25-1 Вострых Александр Евгеньевич", "");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxVarA_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            textBoxResult.Text = res.ToString();
        }
    }
}
