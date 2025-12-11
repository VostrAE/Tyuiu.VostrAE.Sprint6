using Tyuiu.VostrAE.Sprint6.Task6.V14;
using Tyuiu.VostrAE.Sprint6.Task7.V24.Lib;

namespace Tyuiu.VostrAE.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
       static int rows;
       static int colums;
        static string openFilePath;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void buttonOpen_AE_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_AE.ColumnCount = colums;
            dataGridViewIn_AE.RowCount = rows;
            dataGridViewOut_AE.ColumnCount = colums;
            dataGridViewOut_AE.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_AE.Columns[i].Width = 25;
                dataGridViewOut_AE.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewIn_AE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonDone_AE.Enabled = true;

        }

        private void buttonInfo_AE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_AE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            int Rows = arrayValues.GetLength(0);
            int Columns = arrayValues.GetLength(1);
            dataGridViewOut_AE.ColumnCount = Columns;
            dataGridViewOut_AE.RowCount = Rows;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    dataGridViewOut_AE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_AE.Enabled = true;
        }

        private void buttonSave_AE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists) { File.Delete(path); }
            int rows =dataGridViewOut_AE.RowCount;
            int columns = dataGridViewOut_AE.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_AE.Rows[i].Cells[j].Value+";";
                    }
                    else
                    {
                        str += dataGridViewOut_AE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str+ Environment.NewLine);
                str = "";
            }
        }
    }
}
