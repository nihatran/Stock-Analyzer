namespace Stock_Analyzer
{
    partial class FormStockLoader
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
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.groupBoxViewType = new System.Windows.Forms.GroupBox();
            this.radioButtonChartView = new System.Windows.Forms.RadioButton();
            this.radioButtonGridView = new System.Windows.Forms.RadioButton();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxFile = new System.Windows.Forms.ComboBox();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxViewType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(31, 45);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(40, 13);
            this.labelTicker.TabIndex = 0;
            this.labelTicker.Text = "Ticker:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(31, 100);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(58, 13);
            this.labelStartDate.TabIndex = 2;
            this.labelStartDate.Text = "Start Date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(95, 94);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 3;
            this.dateTimePickerStartDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(31, 160);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 13);
            this.labelEndDate.TabIndex = 4;
            this.labelEndDate.Text = "End Date:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(95, 153);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 5;
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.radioButtonMonthly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonWeekly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonDaily);
            this.groupBoxPeriod.Location = new System.Drawing.Point(34, 230);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(160, 120);
            this.groupBoxPeriod.TabIndex = 6;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(7, 85);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMonthly.TabIndex = 2;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.aRadioButtonWasChecked);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(7, 52);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(61, 17);
            this.radioButtonWeekly.TabIndex = 1;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.aRadioButtonWasChecked);
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Checked = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(7, 20);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDaily.TabIndex = 0;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.aRadioButtonWasChecked);
            // 
            // groupBoxViewType
            // 
            this.groupBoxViewType.Controls.Add(this.radioButtonChartView);
            this.groupBoxViewType.Controls.Add(this.radioButtonGridView);
            this.groupBoxViewType.Location = new System.Drawing.Point(253, 230);
            this.groupBoxViewType.Name = "groupBoxViewType";
            this.groupBoxViewType.Size = new System.Drawing.Size(160, 120);
            this.groupBoxViewType.TabIndex = 7;
            this.groupBoxViewType.TabStop = false;
            this.groupBoxViewType.Text = "View Type";
            // 
            // radioButtonChartView
            // 
            this.radioButtonChartView.AutoSize = true;
            this.radioButtonChartView.Checked = true;
            this.radioButtonChartView.Location = new System.Drawing.Point(7, 20);
            this.radioButtonChartView.Name = "radioButtonChartView";
            this.radioButtonChartView.Size = new System.Drawing.Size(98, 17);
            this.radioButtonChartView.TabIndex = 1;
            this.radioButtonChartView.TabStop = true;
            this.radioButtonChartView.Text = "Use Chart View";
            this.radioButtonChartView.UseVisualStyleBackColor = true;
            // 
            // radioButtonGridView
            // 
            this.radioButtonGridView.AutoSize = true;
            this.radioButtonGridView.Location = new System.Drawing.Point(7, 52);
            this.radioButtonGridView.Name = "radioButtonGridView";
            this.radioButtonGridView.Size = new System.Drawing.Size(92, 17);
            this.radioButtonGridView.TabIndex = 0;
            this.radioButtonGridView.Text = "Use Grid View";
            this.radioButtonGridView.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(496, 271);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(160, 80);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load Ticker";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxFile
            // 
            this.comboBoxFile.FormattingEnabled = true;
            this.comboBoxFile.Location = new System.Drawing.Point(95, 42);
            this.comboBoxFile.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFile.Name = "comboBoxFile";
            this.comboBoxFile.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFile.TabIndex = 11;
            // 
            // FormStockLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 466);
            this.Controls.Add(this.comboBoxFile);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.groupBoxViewType);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelTicker);
            this.Name = "FormStockLoader";
            this.Text = "Form Stock Loader";
            this.Load += new System.EventHandler(this.aRadioButtonWasChecked);
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.groupBoxViewType.ResumeLayout(false);
            this.groupBoxViewType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.GroupBox groupBoxViewType;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonChartView;
        private System.Windows.Forms.RadioButton radioButtonGridView;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxFile;
    }
}