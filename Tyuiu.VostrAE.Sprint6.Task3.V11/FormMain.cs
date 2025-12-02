using Tyuiu.VostrAE.Sprint6.Task3.V11.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.VostrAE.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 27, -15, 14, 2, 27 }, { -8, 14, -10, 33, 0 }, { 1, 7, -11, -11, 23 }, { -13, -20, 15, -16, 34 }, { -3, 1, -1, 5, 1 } };


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-25-1 Вострых Александр Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;
            dataGridViewMtrx.ColumnCount = colums;
            dataGridViewMtrx.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewMtrx.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMtrx.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int[,] nMatrix = ds.Calculate(mtrx);
            string result = "";
            for (int i = 0; i < nMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nMatrix.GetLength(1); j++)
                {
                    result += $"{nMatrix[i, j],4} ";
                }
                result += "\r\n";
            }
            textBoxResult.Text = result;
        }
    }
}
