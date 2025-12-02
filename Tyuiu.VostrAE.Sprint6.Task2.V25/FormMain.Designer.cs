namespace Tyuiu.VostrAE.Sprint6.Task2.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnY = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxEndStep = new TextBox();
            textBoxStartStep = new TextBox();
            buttonExit = new Button();
            buttonInfo = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 326);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(583, 294);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartFunction);
            groupBox2.Controls.Add(dataGridViewFunction);
            groupBox2.Location = new Point(619, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(717, 422);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(201, 28);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(501, 366);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chartFunction";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnY });
            dataGridViewFunction.Location = new Point(19, 26);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(158, 376);
            dataGridViewFunction.TabIndex = 0;
            dataGridViewFunction.CellContentClick += dataGridViewFunction_CellContentClick;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 50;
            // 
            // ColumnY
            // 
            ColumnY.HeaderText = "F(X)";
            ColumnY.MinimumWidth = 6;
            ColumnY.Name = "ColumnY";
            ColumnY.Width = 50;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxEndStep);
            groupBox3.Controls.Add(textBoxStartStep);
            groupBox3.Location = new Point(12, 344);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(284, 92);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 33);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            // 
            // textBoxEndStep
            // 
            textBoxEndStep.Location = new Point(153, 56);
            textBoxEndStep.Name = "textBoxEndStep";
            textBoxEndStep.Size = new Size(125, 27);
            textBoxEndStep.TabIndex = 1;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 56);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.ForestGreen;
            buttonExit.Location = new Point(412, 349);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(195, 87);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выполнить";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            buttonExit.MouseDown += buttonExit_MouseDown;
            buttonExit.MouseLeave += buttonExit_MouseLeave;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.DarkCyan;
            buttonInfo.Location = new Point(302, 349);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(104, 87);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonExit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Cпринт 6 | Таск 2 | Варинат 25 | Вострых А.Е.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxEndStep;
        private TextBox textBoxStartStep;
        private Label label2;
        private Button buttonExit;
        private Button buttonInfo;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnY;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
