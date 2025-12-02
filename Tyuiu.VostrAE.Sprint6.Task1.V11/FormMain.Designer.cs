namespace Tyuiu.VostrAE.Sprint6.Task1.V11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxTask = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBoxExit = new GroupBox();
            labelExit = new Label();
            textBoxExit = new TextBox();
            groupBoxEnter = new GroupBox();
            labelEnterEnd = new Label();
            labelEnterStart = new Label();
            buttonRun = new Button();
            buttonInfo = new Button();
            textBoxEnterStart = new TextBox();
            textBoxEnterEnd = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxExit.SuspendLayout();
            groupBoxEnter.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(11, 16);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(492, 298);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(484, 263);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на интервале.\r\nРезультат вывести в таблицу.";
            // 
            // groupBoxExit
            // 
            groupBoxExit.Controls.Add(labelExit);
            groupBoxExit.Controls.Add(textBoxExit);
            groupBoxExit.Location = new Point(509, 16);
            groupBoxExit.Name = "groupBoxExit";
            groupBoxExit.Size = new Size(279, 428);
            groupBoxExit.TabIndex = 1;
            groupBoxExit.TabStop = false;
            groupBoxExit.Text = "Вывод данных";
            groupBoxExit.Enter += groupBoxExit_Enter;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Location = new Point(9, 23);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(78, 20);
            labelExit.TabIndex = 1;
            labelExit.Text = "Результат:";
            labelExit.Click += label1_Click;
            // 
            // textBoxExit
            // 
            textBoxExit.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxExit.Location = new Point(19, 46);
            textBoxExit.Multiline = true;
            textBoxExit.Name = "textBoxExit";
            textBoxExit.ReadOnly = true;
            textBoxExit.ScrollBars = ScrollBars.Vertical;
            textBoxExit.Size = new Size(260, 367);
            textBoxExit.TabIndex = 0;
            textBoxExit.TextChanged += textBoxExit_TextChanged;
            // 
            // groupBoxEnter
            // 
            groupBoxEnter.Controls.Add(textBoxEnterEnd);
            groupBoxEnter.Controls.Add(textBoxEnterStart);
            groupBoxEnter.Controls.Add(labelEnterEnd);
            groupBoxEnter.Controls.Add(labelEnterStart);
            groupBoxEnter.Location = new Point(11, 320);
            groupBoxEnter.Name = "groupBoxEnter";
            groupBoxEnter.Size = new Size(248, 109);
            groupBoxEnter.TabIndex = 2;
            groupBoxEnter.TabStop = false;
            groupBoxEnter.Text = "Ввод данных";
            // 
            // labelEnterEnd
            // 
            labelEnterEnd.AutoSize = true;
            labelEnterEnd.Location = new Point(129, 37);
            labelEnterEnd.Name = "labelEnterEnd";
            labelEnterEnd.Size = new Size(94, 20);
            labelEnterEnd.TabIndex = 5;
            labelEnterEnd.Text = "Конец шага:";
            labelEnterEnd.Click += label1_Click_1;
            // 
            // labelEnterStart
            // 
            labelEnterStart.AutoSize = true;
            labelEnterStart.Location = new Point(9, 37);
            labelEnterStart.Name = "labelEnterStart";
            labelEnterStart.Size = new Size(88, 20);
            labelEnterStart.TabIndex = 5;
            labelEnterStart.Text = "Старт шага:";
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.OliveDrab;
            buttonRun.Location = new Point(365, 352);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(132, 66);
            buttonRun.TabIndex = 3;
            buttonRun.Text = "Выполнить";
            buttonRun.UseVisualStyleBackColor = false;
            buttonRun.Click += buttonRun_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.CadetBlue;
            buttonInfo.Location = new Point(265, 352);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 66);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += button3_Click;
            // 
            // textBoxEnterStart
            // 
            textBoxEnterStart.Location = new Point(9, 71);
            textBoxEnterStart.Name = "textBoxEnterStart";
            textBoxEnterStart.Size = new Size(105, 27);
            textBoxEnterStart.TabIndex = 6;
            textBoxEnterStart.TextChanged += textBoxEnterStart_TextChanged;
            // 
            // textBoxEnterEnd
            // 
            textBoxEnterEnd.Location = new Point(129, 71);
            textBoxEnterEnd.Name = "textBoxEnterEnd";
            textBoxEnterEnd.Size = new Size(105, 27);
            textBoxEnterEnd.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonRun);
            Controls.Add(groupBoxEnter);
            Controls.Add(groupBoxExit);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Cпринт 6 | Таск 1 | Варинат 11 | Вострых А.Е.";
            Load += Form1_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxExit.ResumeLayout(false);
            groupBoxExit.PerformLayout();
            groupBoxEnter.ResumeLayout(false);
            groupBoxEnter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxExit;
        private TextBox textBox1;
        private GroupBox groupBoxEnter;
        private PictureBox pictureBox1;
        private TextBox textBoxExit;
        private Label labelExit;
        private Button buttonRun;
        private Label labelEnterEnd;
        private Label labelEnterStart;
        private Button buttonInfo;
        private TextBox textBoxEnterStart;
        private TextBox textBoxEnterEnd;
    }
}
