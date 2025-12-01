namespace Tyuiu.VostrAE.Sprint6.Task0.V9
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            groupBox2 = new GroupBox();
            TextBoxVarA = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(545, 393);
            button2.Name = "button2";
            button2.Size = new Size(52, 45);
            button2.TabIndex = 5;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonHelp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(603, 393);
            button1.Name = "button1";
            button1.Size = new Size(185, 45);
            button1.TabIndex = 4;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(601, 171);
            textBox1.TabIndex = 3;
            textBox1.Text = "Вычилить выражение по формуле:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(635, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(458, 215);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(330, 166);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 88);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(189, 27);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBox2_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TextBoxVarA);
            groupBox2.Location = new Point(12, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 166);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // TextBoxVarA
            // 
            TextBoxVarA.Location = new Point(6, 88);
            TextBoxVarA.Name = "TextBoxVarA";
            TextBoxVarA.Size = new Size(125, 27);
            TextBoxVarA.TabIndex = 0;
            TextBoxVarA.TextChanged += TextBoxVarA_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 465);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cпринт 6 | Таск 0 | Варинат 9 | Вострых А.Е.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBoxResult;
        private TextBox TextBoxVarA;
    }
}
