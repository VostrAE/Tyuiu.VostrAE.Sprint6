namespace Tyuiu.VostrAE.Sprint6.Task7.V24
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_AE = new Panel();
            groupBoxOutput_AE = new GroupBox();
            dataGridViewOut_AE = new DataGridView();
            buttonInfo_AE = new Button();
            buttonDone_AE = new Button();
            buttonOpen_AE = new Button();
            panelInfo = new Panel();
            groupBoxInfo_AE = new GroupBox();
            labelInfo_AE = new Label();
            splitter = new Splitter();
            groupBoxInput_AE = new GroupBox();
            dataGridViewIn_AE = new DataGridView();
            panelIN_AE = new Panel();
            buttonSave_AE = new Button();
            panelButton_AE.SuspendLayout();
            groupBoxOutput_AE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AE).BeginInit();
            panelInfo.SuspendLayout();
            groupBoxInfo_AE.SuspendLayout();
            groupBoxInput_AE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AE).BeginInit();
            panelIN_AE.SuspendLayout();
            SuspendLayout();
            // 
            // panelButton_AE
            // 
            panelButton_AE.Controls.Add(buttonSave_AE);
            panelButton_AE.Controls.Add(buttonInfo_AE);
            panelButton_AE.Controls.Add(buttonDone_AE);
            panelButton_AE.Controls.Add(buttonOpen_AE);
            panelButton_AE.Dock = DockStyle.Top;
            panelButton_AE.Location = new Point(0, 0);
            panelButton_AE.Name = "panelButton_AE";
            panelButton_AE.Size = new Size(1379, 91);
            panelButton_AE.TabIndex = 0;
            panelButton_AE.UseWaitCursor = true;
            // 
            // groupBoxOutput_AE
            // 
            groupBoxOutput_AE.Controls.Add(dataGridViewOut_AE);
            groupBoxOutput_AE.Location = new Point(695, 191);
            groupBoxOutput_AE.Name = "groupBoxOutput_AE";
            groupBoxOutput_AE.Size = new Size(678, 552);
            groupBoxOutput_AE.TabIndex = 3;
            groupBoxOutput_AE.TabStop = false;
            groupBoxOutput_AE.Text = "Вывод:";
            groupBoxOutput_AE.UseWaitCursor = true;
            // 
            // dataGridViewOut_AE
            // 
            dataGridViewOut_AE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AE.Location = new Point(7, 26);
            dataGridViewOut_AE.Name = "dataGridViewOut_AE";
            dataGridViewOut_AE.ReadOnly = true;
            dataGridViewOut_AE.RowHeadersWidth = 51;
            dataGridViewOut_AE.ScrollBars = ScrollBars.Vertical;
            dataGridViewOut_AE.Size = new Size(664, 517);
            dataGridViewOut_AE.TabIndex = 1;
            dataGridViewOut_AE.UseWaitCursor = true;
            // 
            // buttonInfo_AE
            // 
            buttonInfo_AE.FlatStyle = FlatStyle.Flat;
            buttonInfo_AE.Image = (Image)resources.GetObject("buttonInfo_AE.Image");
            buttonInfo_AE.Location = new Point(1243, 5);
            buttonInfo_AE.Name = "buttonInfo_AE";
            buttonInfo_AE.Size = new Size(122, 80);
            buttonInfo_AE.TabIndex = 4;
            buttonInfo_AE.UseVisualStyleBackColor = true;
            buttonInfo_AE.UseWaitCursor = true;
            // 
            // buttonDone_AE
            // 
            buttonDone_AE.Enabled = false;
            buttonDone_AE.FlatStyle = FlatStyle.Flat;
            buttonDone_AE.Image = (Image)resources.GetObject("buttonDone_AE.Image");
            buttonDone_AE.Location = new Point(139, 5);
            buttonDone_AE.Name = "buttonDone_AE";
            buttonDone_AE.Size = new Size(122, 80);
            buttonDone_AE.TabIndex = 3;
            buttonDone_AE.UseVisualStyleBackColor = true;
            buttonDone_AE.UseWaitCursor = true;
            // 
            // buttonOpen_AE
            // 
            buttonOpen_AE.FlatStyle = FlatStyle.Flat;
            buttonOpen_AE.Image = (Image)resources.GetObject("buttonOpen_AE.Image");
            buttonOpen_AE.Location = new Point(11, 5);
            buttonOpen_AE.Name = "buttonOpen_AE";
            buttonOpen_AE.Size = new Size(122, 80);
            buttonOpen_AE.TabIndex = 2;
            buttonOpen_AE.UseVisualStyleBackColor = true;
            buttonOpen_AE.UseWaitCursor = true;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(groupBoxInfo_AE);
            panelInfo.Controls.Add(splitter);
            panelInfo.Location = new Point(1, 91);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1377, 91);
            panelInfo.TabIndex = 1;
            // 
            // groupBoxInfo_AE
            // 
            groupBoxInfo_AE.Controls.Add(labelInfo_AE);
            groupBoxInfo_AE.Location = new Point(11, 6);
            groupBoxInfo_AE.Name = "groupBoxInfo_AE";
            groupBoxInfo_AE.Size = new Size(1354, 79);
            groupBoxInfo_AE.TabIndex = 2;
            groupBoxInfo_AE.TabStop = false;
            groupBoxInfo_AE.Text = "Условие:";
            // 
            // labelInfo_AE
            // 
            labelInfo_AE.AutoSize = true;
            labelInfo_AE.Location = new Point(6, 23);
            labelInfo_AE.Name = "labelInfo_AE";
            labelInfo_AE.Size = new Size(1159, 40);
            labelInfo_AE.TabIndex = 0;
            labelInfo_AE.Text = resources.GetString("labelInfo_AE.Text");
            // 
            // splitter
            // 
            splitter.Location = new Point(0, 0);
            splitter.Name = "splitter";
            splitter.Size = new Size(1377, 91);
            splitter.TabIndex = 0;
            splitter.TabStop = false;
            // 
            // groupBoxInput_AE
            // 
            groupBoxInput_AE.Controls.Add(dataGridViewIn_AE);
            groupBoxInput_AE.Location = new Point(11, 9);
            groupBoxInput_AE.Name = "groupBoxInput_AE";
            groupBoxInput_AE.Size = new Size(678, 552);
            groupBoxInput_AE.TabIndex = 2;
            groupBoxInput_AE.TabStop = false;
            groupBoxInput_AE.Text = "Ввод:";
            // 
            // dataGridViewIn_AE
            // 
            dataGridViewIn_AE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AE.Location = new Point(8, 26);
            dataGridViewIn_AE.Name = "dataGridViewIn_AE";
            dataGridViewIn_AE.ReadOnly = true;
            dataGridViewIn_AE.RowHeadersWidth = 51;
            dataGridViewIn_AE.ScrollBars = ScrollBars.Vertical;
            dataGridViewIn_AE.Size = new Size(664, 517);
            dataGridViewIn_AE.TabIndex = 0;
            // 
            // panelIN_AE
            // 
            panelIN_AE.Controls.Add(groupBoxInput_AE);
            panelIN_AE.Location = new Point(0, 182);
            panelIN_AE.Name = "panelIN_AE";
            panelIN_AE.Size = new Size(694, 561);
            panelIN_AE.TabIndex = 2;
            // 
            // buttonSave_AE
            // 
            buttonSave_AE.Enabled = false;
            buttonSave_AE.FlatStyle = FlatStyle.Flat;
            buttonSave_AE.Image = (Image)resources.GetObject("buttonSave_AE.Image");
            buttonSave_AE.Location = new Point(267, 5);
            buttonSave_AE.Name = "buttonSave_AE";
            buttonSave_AE.Size = new Size(122, 80);
            buttonSave_AE.TabIndex = 5;
            buttonSave_AE.UseVisualStyleBackColor = true;
            buttonSave_AE.UseWaitCursor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 743);
            Controls.Add(groupBoxOutput_AE);
            Controls.Add(panelIN_AE);
            Controls.Add(panelInfo);
            Controls.Add(panelButton_AE);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 24 | Вострых А.Е.";
            panelButton_AE.ResumeLayout(false);
            groupBoxOutput_AE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AE).EndInit();
            panelInfo.ResumeLayout(false);
            groupBoxInfo_AE.ResumeLayout(false);
            groupBoxInfo_AE.PerformLayout();
            groupBoxInput_AE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AE).EndInit();
            panelIN_AE.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_AE;
        private Panel panelInfo;
        private GroupBox groupBoxInfo_AE;
        private Splitter splitter;
        private Label labelInfo_AE;
        private GroupBox groupBoxInput_AE;
        private DataGridView dataGridViewIn_AE;
        private GroupBox groupBoxOutput_AE;
        private Button buttonInfo_AE;
        private Button buttonDone_AE;
        private Button buttonOpen_AE;
        private DataGridView dataGridViewOut_AE;
        private Panel panelIN_AE;
        private Button buttonSave_AE;
    }
}
