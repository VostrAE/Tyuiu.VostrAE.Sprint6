using Tyuiu.VostrAE.Sprint6.Task6.V14.Lib;
namespace Tyuiu.VostrAE.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
       
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            textBoxOut.Text = textBoxOut.Text + "" + openFileDialogTask.FileName; ;
            buttonTask.Enabled = true;
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            

            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
