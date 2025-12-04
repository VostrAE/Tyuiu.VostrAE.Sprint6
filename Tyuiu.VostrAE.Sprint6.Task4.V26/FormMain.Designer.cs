namespace Tyuiu.VostrAE.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxEnter = new GroupBox();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonEnter = new Button();
            labelStop = new Label();
            labelStart = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBoxInfo = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxInfo = new TextBox();
            groupBoxOut = new GroupBox();
            textBoxOut = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxEnter.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEnter
            // 
            groupBoxEnter.Controls.Add(buttonInfo);
            groupBoxEnter.Controls.Add(buttonSave);
            groupBoxEnter.Controls.Add(buttonEnter);
            groupBoxEnter.Controls.Add(labelStop);
            groupBoxEnter.Controls.Add(labelStart);
            groupBoxEnter.Controls.Add(textBoxStop);
            groupBoxEnter.Controls.Add(textBoxStart);
            groupBoxEnter.Location = new Point(695, 10);
            groupBoxEnter.Name = "groupBoxEnter";
            groupBoxEnter.Size = new Size(732, 120);
            groupBoxEnter.TabIndex = 0;
            groupBoxEnter.TabStop = false;
            groupBoxEnter.Text = "Ввод данных:";
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.HotTrack;
            buttonInfo.Location = new Point(578, 24);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(130, 79);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Location = new Point(442, 24);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 78);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.MediumSeaGreen;
            buttonEnter.Location = new Point(306, 24);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(130, 78);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Выполнить";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(178, 29);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(94, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(18, 29);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(88, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(178, 52);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(109, 27);
            textBoxStop.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(18, 52);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(109, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(pictureBox1);
            groupBoxInfo.Controls.Add(textBoxInfo);
            groupBoxInfo.Location = new Point(12, 10);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(677, 127);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Условие:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(6, 26);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(665, 94);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = "Протабулировать функцию на заданном диапазоне. \r\nРезультат вывести в textBox, построить график фунции и сохранить в файл по нажатию кнопки.";
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxOut);
            groupBoxOut.Location = new Point(12, 143);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(442, 707);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных:";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(6, 26);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(430, 661);
            textBoxOut.TabIndex = 0;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(470, 143);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(967, 707);
            chartFunction.TabIndex = 2;
            chartFunction.Text = "График функции";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 862);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxInfo);
            Controls.Add(groupBoxEnter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cпринт 6 | Таск 4 | Варинат 26 | Вострых А.Е.";
            groupBoxEnter.ResumeLayout(false);
            groupBoxEnter.PerformLayout();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEnter;
        private GroupBox groupBoxInfo;
        private GroupBox groupBoxOut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private PictureBox pictureBox1;
        private TextBox textBoxInfo;
        private TextBox textBoxOut;
        private Button buttonEnter;
        private Label labelStop;
        private Label labelStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonInfo;
        private Button buttonSave;
    }
}
