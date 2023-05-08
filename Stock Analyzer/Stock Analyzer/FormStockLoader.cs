
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stock_Analyzer
{
    /// <summary>
    /// First windows form, event for comboBox file names when radio button checked, event for clicking load button
    /// Inside load button event: read list of candlesticks, create second windows form containing chart/data grid view
    /// </summary>
    public partial class FormStockLoader : Form
    {
        // Declare object of class CandlestickReader and Candlestick
        List<Candlestick> listOfCandlesticks = null;
        CandlestickReader candlestickReader = null;
        const string dataFolder = "Stock Data";

        public FormStockLoader()
        {
            InitializeComponent();
            // Object is created, constructor is called
            candlestickReader = new CandlestickReader();
        }

        /// <summary>
        /// Event: When a radio button is checked:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aRadioButtonWasChecked(object sender, EventArgs e)
        {
            // Start with *-period.csv for the filename pattern, * is the ticker
            // Assume that the user's default choice is daily
            string targetFilenamesPattern = "*-Day.csv";
            // If weekly is chosen
            if (radioButtonWeekly.Checked)
            {
                targetFilenamesPattern = "*-Week.csv";
            }
            else if (radioButtonMonthly.Checked)
            {
                // If monthly is chosen
                targetFilenamesPattern = "*-Month.csv";
            }

            // Now that we have the file name pattern, go get all the filenames that match the pattern
            // filenames are stored in a list of type string called fullFilenames
            string[] fullFilenames = Directory.GetFiles(dataFolder, targetFilenamesPattern);

            // Clear the combo box of all previous filenames
            comboBoxFile.Items.Clear();

            // Create a new list of strings called files to hold the shortened filenames
            List<string> files = new List<string>(fullFilenames.Length);
            // Go through all the full filename paths in the data folder
            foreach (string fullFilename in fullFilenames)
            {
                // Extract just the filename out of the fullpath string
                string filename = Path.GetFileNameWithoutExtension(fullFilename);
                // Add that filename to the comboBox with its Items property
                comboBoxFile.Items.Add(filename);
            }

            // Once done, select the first item to display in the comboBox window 
            comboBoxFile.SelectedIndex = 0;
        }

        /// <summary>
        /// Event: When the Load button is clicked: 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {

            // If we have some selected text in the comboBox
            if (comboBoxFile.Text != string.Empty)
            {
                // Form the path name of the selected file from comboBox Text property
                string targetFilename = dataFolder + @"\" + comboBoxFile.Text + ".csv";

                // Splitting the text in the comboBox to get the ticker and period, '-' is the separator
                string[] separators = { "-" };
                string[] temp = comboBoxFile.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // First part of the comboBox text is the ticker, second part of the the comboBox text is the period
                string ticker = temp[0];
                string period = temp[1];

                // ReadStock is called to create the list of candlesticks
                listOfCandlesticks = candlestickReader.ReadStock(targetFilename, dateTimePickerStartDate.Value, dateTimePickerEndDate.Value, ticker, period);

                // Determine if chart view or grid view is displayed using radio buttons
                if (radioButtonChartView.Checked)
                {
                    // Display the candlesticks in chart view
                    // Source: C# Stock Chart and Candlestick Chart Winforms .Net FoxLearn https://www.youtube.com/watch?v=IGKSaH4yz-g

                    // When you click on Load, a new form with chart is made and appears
                    // The list of candlesticks is passed to the new form
                    FormStockViewerChart FormChart = new FormStockViewerChart(listOfCandlesticks);

                    // Clear chart
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].AxisX.MajorGrid.LineWidth = 0;
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].AxisY.MajorGrid.LineWidth = 0;
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].AxisY.IsStartedFromZero = false;
                    // FormChart.chartCandlesticks.ChartAreas["OHLC"].AxisY.Interval = 5;

                    // Set the x and y values, candlestick colors of the chart
                    // Make sure chart y axis starts at the first candlestick
                    FormChart.chartCandlesticks.Series["OHLC"].XValueMember = "Date";
                    FormChart.chartCandlesticks.Series["OHLC"].YValueMembers = "High,Low,Open,Close";
                    FormChart.chartCandlesticks.Series["OHLC"].CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
                    FormChart.chartCandlesticks.DataManipulator.IsStartFromFirst = true;
                    
                    // Chart scaling, user can scroll and zoom in/out
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].AxisX.ScaleView.Zoomable = true;
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].AxisY.ScaleView.Zoomable = true;
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].CursorX.AutoScroll = true;
                    FormChart.chartCandlesticks.ChartAreas["OHLC"].CursorX.IsUserSelectionEnabled = true;

                    // Binding list of candlesticks to the chart on the new form
                    FormChart.chartCandlesticks.DataSource = listOfCandlesticks;
                    FormChart.chartCandlesticks.DataBind();

                    // Name the chart/series with the ticker and period
                    FormChart.Text = ticker + "-" + period + " Chart";
                    FormChart.chartCandlesticks.Series["OHLC"].Name = ticker + "-" + period;

                    // Show chart
                    FormChart.Show();

                }

                // Display the candlesticks in data grid view
                else if (radioButtonGridView.Checked)
                {
                    // When you click on Load, a new form with data grid view is made and appears
                    // Bind list of candlesticks to data grid view on new form
                    FormStockViewerDataGridView FormDataGridView = new FormStockViewerDataGridView();
                    FormDataGridView.dataGridViewCandlesticks.DataSource = listOfCandlesticks;
                    FormDataGridView.Show();

                    // Name the data grid view with the ticker and period
                    FormDataGridView.Text = ticker + "-" + period + " Data Grid View";

                    // x.ShowDialog shows new form but focus is put on that form only
                }

            }

        }

    }

}

