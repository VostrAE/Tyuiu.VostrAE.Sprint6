namespace Tyuiu.VostrAE.Sprint6.Task5.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            groupBoxOut = new GroupBox();
            DataGridViewNums = new DataGridView();
            panel4 = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel3 = new Panel();
            panel1 = new Panel();
            buttonEnter = new Button();
            buttonInfo = new Button();
            buttonOpen = new Button();
            groupBoxInfo = new GroupBox();
            textBoxInfo = new TextBox();
            panel2.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewNums).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            panel1.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBoxOut);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 519);
            panel2.TabIndex = 1;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(DataGridViewNums);
            groupBoxOut.Location = new Point(12, 6);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(318, 501);
            groupBoxOut.TabIndex = 1;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных:";
            // 
            // DataGridViewNums
            // 
            DataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewNums.Location = new Point(6, 26);
            DataGridViewNums.Name = "DataGridViewNums";
            DataGridViewNums.ReadOnly = true;
            DataGridViewNums.RowHeadersWidth = 51;
            DataGridViewNums.ScrollBars = ScrollBars.Vertical;
            DataGridViewNums.Size = new Size(306, 469);
            DataGridViewNums.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(chartFunction);
            panel4.Controls.Add(splitter1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(336, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(748, 519);
            panel4.TabIndex = 2;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(10, 0);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.LabelFormat = "График функции";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(726, 501);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 519);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(336, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 522);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonEnter);
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonOpen);
            panel1.Controls.Add(groupBoxInfo);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 121);
            panel1.TabIndex = 0;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.YellowGreen;
            buttonEnter.Location = new Point(715, 6);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(115, 102);
            buttonEnter.TabIndex = 6;
            buttonEnter.Text = "Выполнить";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ActiveCaption;
            buttonInfo.Location = new Point(957, 6);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(115, 102);
            buttonInfo.TabIndex = 5;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = SystemColors.Highlight;
            buttonOpen.Location = new Point(836, 6);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(115, 102);
            buttonOpen.TabIndex = 4;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBoxInfo);
            groupBoxInfo.Location = new Point(12, 3);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(681, 111);
            groupBoxInfo.TabIndex = 3;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Условие:";
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(6, 26);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(669, 79);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = "Прочитать данные из файла. Вывести положительные значения и построить диаграмму по этим значениям.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 640);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Cпринт 6 | Таск 5 | Варинат 29 | Вострых А.Е.";
            panel2.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewNums).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            panel1.ResumeLayout(false);
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private Splitter splitter1;
        private Panel panel3;
        private Panel panel1;
        private GroupBox groupBoxInfo;
        private TextBox textBoxInfo;
        private GroupBox groupBoxOut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonEnter;
        private Button buttonInfo;
        private Button buttonOpen;
        private DataGridView DataGridViewNums;
    }
}
