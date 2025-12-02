namespace Tyuiu.VostrAE.Sprint6.Task3.V11
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
            groupBoxInfo = new GroupBox();
            textBox2 = new TextBox();
            groupBoxResult = new GroupBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            buttonResult = new Button();
            buttonInfo = new Button();
            dataGridViewMtrx = new DataGridView();
            groupBoxInfo.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBox2);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(279, 366);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Условие:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(255, 334);
            textBox2.TabIndex = 4;
            textBox2.Text = "Дана матрица 5 на 5.\r\n\r\n27 -15  14   2  27\r\n\r\n -8  14 -10  33   0\r\n\r\n1   7 -11 -11  23\r\n\r\n-13 -20  15 -16  34\r\n\r\n-3   1  -1   5   1\r\n\r\nВыполнить сортировку по возрастанию в первом столбце.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(642, 21);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(208, 294);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 35);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(8, 58);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(186, 216);
            textBoxResult.TabIndex = 0;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(709, 321);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(141, 57);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(642, 321);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(61, 57);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // dataGridViewMtrx
            // 
            dataGridViewMtrx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx.Location = new Point(307, 21);
            dataGridViewMtrx.Name = "dataGridViewMtrx";
            dataGridViewMtrx.RowHeadersWidth = 51;
            dataGridViewMtrx.Size = new Size(314, 299);
            dataGridViewMtrx.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 390);
            Controls.Add(dataGridViewMtrx);
            Controls.Add(buttonInfo);
            Controls.Add(buttonResult);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInfo);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo;
        private TextBox textBox2;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonResult;
        private Button buttonInfo;
        private DataGridView dataGridViewMtrx;
        private Label labelResult;
    }
}
