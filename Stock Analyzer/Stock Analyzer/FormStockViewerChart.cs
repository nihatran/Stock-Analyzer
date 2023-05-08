using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Stock_Analyzer.SingleCandlestickRecognizers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock_Analyzer
{
    /// <summary>
    /// Second windows form chart that contains 
    /// comboBox/legend for patterns, comboBox patterns event, rectangle annotations
    /// </summary>
    public partial class FormStockViewerChart : Form
    {
        // Declare public list candlesticks so RecognizeMethod can access it
        public List<Candlestick> candlesticks;

        public FormStockViewerChart(List<Candlestick> listOfCandlesticks)
        {
            // Initialize the recognizers
            // Set candlesticks equal to the listOfCandlesticks that was passed
            InitializeComponent();
            InitializeRecognizers();
            candlesticks = listOfCandlesticks;
        }

        // The list of recognizers for form stock viewer chart
        List<Recognizer> recognizers = new List<Recognizer>(32);
        private List<Recognizer> InitializeRecognizers()
        {
            Recognizer recognizer = null;

            recognizer = new Recognizer_Bullish();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Bearish();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Neutral();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Doji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_DragonflyDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_GravestoneDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_LongLeggedDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_NeutralDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Marubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BlackMarubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_WhiteMarubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Hammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BullishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BearishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_InvertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BullishInvertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BearishInvertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BullishEngulfing();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BearishEngulfing();
            recognizers.Add(recognizer);

            // Now that we have all the single candlestick patterns and multi candlestick patterns,
            // We want to add them to the list of comboBox items

            // Clear the comboBox
            comboBoxPatterns.Items.Clear();

            // For each recognizer in the list of recognizers, 
            // add it to comboBox patterns
            foreach (Recognizer r in recognizers)
            {
                comboBoxPatterns.Items.Add(r.patternName);
            }
            comboBoxPatterns.Enabled = true;

            return recognizers;
        }

        /// <summary>
        /// Event: When a comboBox item is selected: 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The comboBox provides the index for the list of recognizers
            // to find the chosen recognizer 
            Recognizer recognizer = recognizers[comboBoxPatterns.SelectedIndex];

            // Clear the annotations/legend every time a new pattern is selected
            chartCandlesticks.Annotations.Clear();
            chartCandlesticks.Legends["LegendOHLC"].CustomItems.Clear();

            // Recognizer method is called and the result is assigned to patternIndices
            List<int> patternIndices = recognizer.RecognizeMethod(candlesticks);

            // The indices can now be used to display the annotations
            DisplayAnnotations(patternIndices, recognizer.patternName);

        }

        /// <summary>
        /// Display annotations method
        /// </summary>
        /// <param name="patternIndices"></param>
        /// <param name="patternName"></param>
        public void DisplayAnnotations(List<int> patternIndices, string patternName)
        {
            // For every index in the result list, create a rectangle annotation
            foreach (int index in patternIndices)
            {
                RectangleAnnotation rectAnnotation = new RectangleAnnotation();

                // Set the text of the rectangle annotation as the pattern name that was passed
                rectAnnotation.Text = patternName;
                // Anchor the annotation to the location of the candlestick
                rectAnnotation.AnchorDataPoint = chartCandlesticks.Series[0].Points[index];
                // Set the width, line color, and back color of the annotation
                rectAnnotation.LineWidth = 1;
                rectAnnotation.LineColor = Color.Black;
                rectAnnotation.BackColor = Color.FromArgb(50, Color.LightSkyBlue);

                // Add the rectangle annotation to the chart's list of annotations
                chartCandlesticks.Annotations.Add(rectAnnotation);

            }

            // If there is a pattern, show the legend
            if (patternIndices.Count != 0)
            {
                chartCandlesticks.Legends["LegendOHLC"].CustomItems.Add(Color.LightBlue, patternName);
            }
            return;
        }

    }

}
