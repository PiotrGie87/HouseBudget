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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnLoadChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 79);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(563, 350);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(411, 52);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(177, 21);
            this.cb.TabIndex = 7;
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(206, 52);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(194, 21);
            this.cbDate.TabIndex = 6;
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
            this.btnLoadChart.Location = new System.Drawing.Point(64, 436);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(75, 23);
            this.btnLoadChart.TabIndex = 11;
            this.btnLoadChart.Text = "button1";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            // 
            // Diagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 466);
            this.Controls.Add(this.btnLoadChart);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbTag);
            this.Name = "Diagrams";
            this.Text = "Diagrams";
            this.Load += new System.EventHandler(this.Diagrams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Button btnLoadChart;
    }
}