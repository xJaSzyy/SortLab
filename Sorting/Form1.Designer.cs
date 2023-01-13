namespace Sorting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отсортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IsVisualized = new System.Windows.Forms.CheckBox();
            this.ms1 = new System.Windows.Forms.Label();
            this.ms5 = new System.Windows.Forms.Label();
            this.ms4 = new System.Windows.Forms.Label();
            this.ms3 = new System.Windows.Forms.Label();
            this.ms2 = new System.Windows.Forms.Label();
            this.bubbleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IsAll = new System.Windows.Forms.CheckBox();
            this.insertionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quickChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.coctailChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertionChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coctailChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column});
            this.DataGrid.Location = new System.Drawing.Point(12, 27);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(143, 411);
            this.DataGrid.TabIndex = 0;
            // 
            // Column
            // 
            this.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column.HeaderText = "Элементы массива";
            this.Column.Name = "Column";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отсортироватьToolStripMenuItem,
            this.заполнитьМассивToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отсортироватьToolStripMenuItem
            // 
            this.отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            this.отсортироватьToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.отсортироватьToolStripMenuItem.Text = "Отсортировать";
            this.отсортироватьToolStripMenuItem.Click += new System.EventHandler(this.отсортироватьToolStripMenuItem_Click);
            // 
            // заполнитьМассивToolStripMenuItem
            // 
            this.заполнитьМассивToolStripMenuItem.Name = "заполнитьМассивToolStripMenuItem";
            this.заполнитьМассивToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.заполнитьМассивToolStripMenuItem.Text = "Заполнить массив";
            this.заполнитьМассивToolStripMenuItem.Click += new System.EventHandler(this.заполнитьМассивToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(161, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "BubbleSort";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(161, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "InsertionSort";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(161, 71);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "CoctailSort";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(161, 94);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "QuickSort";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(161, 117);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "BogoSort";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // IsVisualized
            // 
            this.IsVisualized.AutoSize = true;
            this.IsVisualized.Location = new System.Drawing.Point(161, 163);
            this.IsVisualized.Name = "IsVisualized";
            this.IsVisualized.Size = new System.Drawing.Size(115, 17);
            this.IsVisualized.TabIndex = 12;
            this.IsVisualized.Text = "Визуализировать";
            this.IsVisualized.UseVisualStyleBackColor = true;
            // 
            // ms1
            // 
            this.ms1.AutoSize = true;
            this.ms1.Location = new System.Drawing.Point(282, 28);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(0, 13);
            this.ms1.TabIndex = 13;
            // 
            // ms5
            // 
            this.ms5.AutoSize = true;
            this.ms5.Location = new System.Drawing.Point(282, 118);
            this.ms5.Name = "ms5";
            this.ms5.Size = new System.Drawing.Size(0, 13);
            this.ms5.TabIndex = 14;
            // 
            // ms4
            // 
            this.ms4.AutoSize = true;
            this.ms4.Location = new System.Drawing.Point(282, 95);
            this.ms4.Name = "ms4";
            this.ms4.Size = new System.Drawing.Size(0, 13);
            this.ms4.TabIndex = 15;
            // 
            // ms3
            // 
            this.ms3.AutoSize = true;
            this.ms3.Location = new System.Drawing.Point(282, 72);
            this.ms3.Name = "ms3";
            this.ms3.Size = new System.Drawing.Size(0, 13);
            this.ms3.TabIndex = 16;
            // 
            // ms2
            // 
            this.ms2.AutoSize = true;
            this.ms2.Location = new System.Drawing.Point(282, 49);
            this.ms2.Name = "ms2";
            this.ms2.Size = new System.Drawing.Size(0, 13);
            this.ms2.TabIndex = 17;
            // 
            // bubbleChart
            // 
            chartArea1.Name = "ChartArea1";
            this.bubbleChart.ChartAreas.Add(chartArea1);
            this.bubbleChart.Location = new System.Drawing.Point(367, 27);
            this.bubbleChart.Name = "bubbleChart";
            series1.ChartArea = "ChartArea1";
            series1.MarkerSize = 1;
            series1.MarkerStep = 100;
            series1.Name = "Series1";
            this.bubbleChart.Series.Add(series1);
            this.bubbleChart.Size = new System.Drawing.Size(200, 200);
            this.bubbleChart.TabIndex = 18;
            this.bubbleChart.Text = "chart1";
            // 
            // IsAll
            // 
            this.IsAll.AutoSize = true;
            this.IsAll.Location = new System.Drawing.Point(161, 140);
            this.IsAll.Name = "IsAll";
            this.IsAll.Size = new System.Drawing.Size(107, 17);
            this.IsAll.TabIndex = 19;
            this.IsAll.Text = "Все сортировки";
            this.IsAll.UseVisualStyleBackColor = true;
            // 
            // insertionChart
            // 
            chartArea2.Name = "ChartArea1";
            this.insertionChart.ChartAreas.Add(chartArea2);
            this.insertionChart.Location = new System.Drawing.Point(573, 27);
            this.insertionChart.Name = "insertionChart";
            series2.ChartArea = "ChartArea1";
            series2.MarkerSize = 1;
            series2.MarkerStep = 100;
            series2.Name = "Series1";
            this.insertionChart.Series.Add(series2);
            this.insertionChart.Size = new System.Drawing.Size(200, 200);
            this.insertionChart.TabIndex = 20;
            this.insertionChart.Text = "chart1";
            // 
            // quickChart
            // 
            chartArea3.Name = "ChartArea1";
            this.quickChart.ChartAreas.Add(chartArea3);
            this.quickChart.Location = new System.Drawing.Point(573, 238);
            this.quickChart.Name = "quickChart";
            series3.ChartArea = "ChartArea1";
            series3.MarkerSize = 1;
            series3.MarkerStep = 100;
            series3.Name = "Series1";
            this.quickChart.Series.Add(series3);
            this.quickChart.Size = new System.Drawing.Size(200, 200);
            this.quickChart.TabIndex = 21;
            this.quickChart.Text = "chart1";
            // 
            // coctailChart
            // 
            chartArea4.Name = "ChartArea1";
            this.coctailChart.ChartAreas.Add(chartArea4);
            this.coctailChart.Location = new System.Drawing.Point(367, 238);
            this.coctailChart.Name = "coctailChart";
            series4.ChartArea = "ChartArea1";
            series4.MarkerSize = 1;
            series4.MarkerStep = 100;
            series4.Name = "Series1";
            this.coctailChart.Series.Add(series4);
            this.coctailChart.Size = new System.Drawing.Size(200, 200);
            this.coctailChart.TabIndex = 22;
            this.coctailChart.Text = "chart1";
            // 
            // chart
            // 
            chartArea5.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea5);
            this.chart.Location = new System.Drawing.Point(161, 238);
            this.chart.Name = "chart";
            series5.ChartArea = "ChartArea1";
            series5.MarkerSize = 1;
            series5.MarkerStep = 100;
            series5.Name = "Series1";
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(200, 200);
            this.chart.TabIndex = 23;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.coctailChart);
            this.Controls.Add(this.quickChart);
            this.Controls.Add(this.insertionChart);
            this.Controls.Add(this.IsAll);
            this.Controls.Add(this.bubbleChart);
            this.Controls.Add(this.ms2);
            this.Controls.Add(this.ms3);
            this.Controls.Add(this.ms4);
            this.Controls.Add(this.ms5);
            this.Controls.Add(this.ms1);
            this.Controls.Add(this.IsVisualized);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertionChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coctailChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox IsVisualized;
        private System.Windows.Forms.Label ms1;
        private System.Windows.Forms.Label ms5;
        private System.Windows.Forms.Label ms4;
        private System.Windows.Forms.Label ms3;
        private System.Windows.Forms.Label ms2;
        private System.Windows.Forms.DataVisualization.Charting.Chart bubbleChart;
        private System.Windows.Forms.CheckBox IsAll;
        private System.Windows.Forms.ToolStripMenuItem заполнитьМассивToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart insertionChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart quickChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart coctailChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

