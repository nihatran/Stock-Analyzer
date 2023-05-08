namespace Stock_Analyzer
{
    partial class FormStockViewerDataGridView
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
            this.dataGridViewCandlesticks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandlesticks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCandlesticks
            // 
            this.dataGridViewCandlesticks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandlesticks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCandlesticks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCandlesticks.Name = "dataGridViewCandlesticks";
            this.dataGridViewCandlesticks.RowHeadersWidth = 51;
            this.dataGridViewCandlesticks.RowTemplate.Height = 24;
            this.dataGridViewCandlesticks.Size = new System.Drawing.Size(893, 538);
            this.dataGridViewCandlesticks.TabIndex = 0;
            // 
            // FormStockViewerDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 538);
            this.Controls.Add(this.dataGridViewCandlesticks);
            this.Name = "FormStockViewerDataGridView";
            this.Text = "Form Stock Viewer Data Grid View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandlesticks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewCandlesticks;
    }
}