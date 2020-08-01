namespace HouseBudget
{
    partial class Diagrams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb = new System.Windows.Forms.ComboBox();
            this.cbAnotherData = new System.Windows.Forms.ComboBox();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.btnChartClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(25, 79);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(563, 350);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart1";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(411, 52);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(177, 21);
            this.cb.TabIndex = 7;
            // 
            // cbAnotherData
            // 
            this.cbAnotherData.FormattingEnabled = true;
            this.cbAnotherData.Items.AddRange(new object[] {
            "Koszt",
            "Budżet",
            "Stosunek procentowy",
            "Data"});
            this.cbAnotherData.Location = new System.Drawing.Point(206, 52);
            this.cbAnotherData.Name = "cbAnotherData";
            this.cbAnotherData.Size = new System.Drawing.Size(194, 21);
            this.cbAnotherData.TabIndex = 6;
            // 
            // cbTag
            // 
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Location = new System.Drawing.Point(25, 52);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(175, 21);
            this.cbTag.TabIndex = 5;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(25, 33);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(86, 13);
            this.lblTag.TabIndex = 9;
            this.lblTag.Text = "Rodzaj Wydatku";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(206, 33);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data";
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.Location = new System.Drawing.Point(608, 104);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(75, 111);
            this.btnLoadChart.TabIndex = 11;
            this.btnLoadChart.Text = "Pokaż";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // btnChartClear
            // 
            this.btnChartClear.Location = new System.Drawing.Point(608, 233);
            this.btnChartClear.Name = "btnChartClear";
            this.btnChartClear.Size = new System.Drawing.Size(75, 111);
            this.btnChartClear.TabIndex = 12;
            this.btnChartClear.Text = "Wyczyść";
            this.btnChartClear.UseVisualStyleBackColor = true;
            this.btnChartClear.Click += new System.EventHandler(this.btnChartClear_Click);
            // 
            // Diagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 466);
            this.Controls.Add(this.btnChartClear);
            this.Controls.Add(this.btnLoadChart);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.cbAnotherData);
            this.Controls.Add(this.cbTag);
            this.Name = "Diagrams";
            this.Text = "Diagrams";
            this.Load += new System.EventHandler(this.Diagrams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.ComboBox cbAnotherData;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.Button btnChartClear;
    }
}