namespace Tyuiu.VostrAE.Sprint6.Task6.V14
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonTask = new Button();
            buttonOpen = new Button();
            splitter5 = new Splitter();
            panel2 = new Panel();
            labelInfo = new Label();
            textBoxInfo = new TextBox();
            splitter2 = new Splitter();
            panel3 = new Panel();
            textBoxOut = new TextBox();
            labelOut = new Label();
            splitter3 = new Splitter();
            panel4 = new Panel();
            textBoxIn = new TextBox();
            labelIn = new Label();
            splitter4 = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonTask);
            panel1.Controls.Add(buttonOpen);
            panel1.Controls.Add(splitter5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 111);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(1160, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(121, 87);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "button3";
            toolTip.SetToolTip(buttonInfo, "Сведения о программе");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(149, 12);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(121, 87);
            buttonTask.TabIndex = 5;
            buttonTask.Text = "button2";
            toolTip.SetToolTip(buttonTask, "Производит поиск в файле");
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTask_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(13, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(121, 87);
            buttonOpen.TabIndex = 4;
            buttonOpen.Text = "buttonOpen";
            toolTip.SetToolTip(buttonOpen, "Открыть файл\r\nВыберите файл для обработку");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // splitter5
            // 
            splitter5.Location = new Point(0, 0);
            splitter5.Name = "splitter5";
            splitter5.Size = new Size(1294, 111);
            splitter5.TabIndex = 0;
            splitter5.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInfo);
            panel2.Controls.Add(textBoxInfo);
            panel2.Controls.Add(splitter2);
            panel2.Location = new Point(12, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1294, 111);
            panel2.TabIndex = 1;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(13, 11);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(70, 20);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "Условие:";
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(3, 34);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(1288, 74);
            textBoxInfo.TabIndex = 4;
            textBoxInfo.Text = "Дан файл. Загрузить его. Обработать его. Вывести результат.";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1294, 111);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxOut);
            panel3.Controls.Add(labelOut);
            panel3.Controls.Add(splitter3);
            panel3.Location = new Point(663, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(643, 432);
            panel3.TabIndex = 2;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(4, 38);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(639, 394);
            textBoxOut.TabIndex = 5;
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Location = new Point(3, 12);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(57, 20);
            labelOut.TabIndex = 4;
            labelOut.Text = "Вывод:";
            // 
            // splitter3
            // 
            splitter3.Location = new Point(0, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(643, 432);
            splitter3.TabIndex = 0;
            splitter3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxIn);
            panel4.Controls.Add(labelIn);
            panel4.Controls.Add(splitter4);
            panel4.Location = new Point(12, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(645, 432);
            panel4.TabIndex = 3;
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(3, 38);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(639, 394);
            textBoxIn.TabIndex = 4;
            // 
            // labelIn
            // 
            labelIn.AutoSize = true;
            labelIn.Location = new Point(3, 12);
            labelIn.Name = "labelIn";
            labelIn.Size = new Size(46, 20);
            labelIn.TabIndex = 4;
            labelIn.Text = "Ввод:";
            // 
            // splitter4
            // 
            splitter4.Location = new Point(0, 0);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(645, 432);
            splitter4.TabIndex = 0;
            splitter4.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 690);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 14| Вострых А.Е.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Splitter splitter2;
        private Panel panel3;
        private Panel panel4;
        private Button buttonInfo;
        private Button buttonTask;
        private Button buttonOpen;
        private Splitter splitter5;
        private Label labelInfo;
        private TextBox textBoxInfo;
        private Splitter splitter3;
        private Splitter splitter4;
        private Label labelOut;
        private Label labelIn;
        private TextBox textBoxOut;
        private TextBox textBoxIn;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
