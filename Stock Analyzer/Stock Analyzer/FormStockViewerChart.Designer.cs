namespace Stock_Analyzer
{
    partial class FormStockViewerChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCandlesticks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxPatterns = new System.Windows.Forms.ComboBox();
            this.labelPatterns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCandlesticks)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCandlesticks
            // 
            chartArea4.Name = "OHLC";
            this.chartCandlesticks.ChartAreas.Add(chartArea4);
            this.chartCandlesticks.Dock = System.Windows.Forms.DockStyle.Top;
            legend4.Name = "LegendOHLC";
            this.chartCandlesticks.Legends.Add(legend4);
            this.chartCandlesticks.Location = new System.Drawing.Point(0, 0);
            this.chartCandlesticks.Margin = new System.Windows.Forms.Padding(2);
            this.chartCandlesticks.Name = "chartCandlesticks";
            series4.ChartArea = "OHLC";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series4.Legend = "LegendOHLC";
            series4.Name = "OHLC";
            series4.YValuesPerPoint = 4;
            this.chartCandlesticks.Series.Add(series4);
            this.chartCandlesticks.Size = new System.Drawing.Size(784, 358);
            this.chartCandlesticks.TabIndex = 0;
            this.chartCandlesticks.Text = "chartCandlesticks";
            // 
            // comboBoxPatterns
            // 
            this.comboBoxPatterns.FormattingEnabled = true;
            this.comboBoxPatterns.Location = new System.Drawing.Point(81, 380);
            this.comboBoxPatterns.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPatterns.Name = "comboBoxPatterns";
            this.comboBoxPatterns.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPatterns.TabIndex = 1;
            this.comboBoxPatterns.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatterns_SelectedIndexChanged);
            // 
            // labelPatterns
            // 
            this.labelPatterns.AutoSize = true;
            this.labelPatterns.Location = new System.Drawing.Point(24, 387);
            this.labelPatterns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPatterns.Name = "labelPatterns";
            this.labelPatterns.Size = new System.Drawing.Size(49, 13);
            this.labelPatterns.TabIndex = 2;
            this.labelPatterns.Text = "Patterns:";
            // 
            // FormStockViewerChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 532);
            this.Controls.Add(this.labelPatterns);
            this.Controls.Add(this.comboBoxPatterns);
            this.Controls.Add(this.chartCandlesticks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStockViewerChart";
            this.Text = "Form Stock Viewer Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartCandlesticks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartCandlesticks;
        private System.Windows.Forms.ComboBox comboBoxPatterns;
        private System.Windows.Forms.Label labelPatterns;
    }
}