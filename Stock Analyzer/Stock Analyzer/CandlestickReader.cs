using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Analyzer
{
    /// <summary>
    /// Class to read candlesticks
    /// </summary>
    internal class CandlestickReader
    {
        const string dataFolder = "Stock Data";

        // Declare list of candlesticks
        public List<Candlestick> listOfCandlesticks = null;

        // Default constructor
        public CandlestickReader()
        {
            listOfCandlesticks = new List<Candlestick>(512);
        }

        /// <summary>
        /// Reading list of candlesticks method
        /// </summary>
        /// <param name="csvFilename"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<Candlestick> ReadListOfCandlesticks(string csvFilename, DateTime startDate, DateTime endDate)
        {
            // Get all the lines as a string array by reading all the lines
            string[] lines = System.IO.File.ReadAllLines(csvFilename);

            // Use the first line (header) to make sure that the file is a valid candlestick file (can check yahoo stock data or class stock data)
            string header = lines[0];
            if (header == "Date,Open,High,Low,Close,Adj Close,Volume")
            {
                // Declare char array of separators
                char[] separators = new char[] { '-', ','};

                // Create a list of candlesticks and state capacity to fit all candlesticks
                listOfCandlesticks = new List<Candlestick>(lines.Length - 1);

                // Start iterating through file until the last line
                for (int l = 1; l < lines.Length; ++l)
                {
                    // Get the lth line
                    string line = lines[l].Trim();

                    // Split it based on ',' and '-' and store it into a string array
                    string[] subStrings = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    // Parse the date info
                    int year = int.Parse(subStrings[0]);
                    int month = int.Parse(subStrings[1]);
                    int day = int.Parse(subStrings[2]);

                    // Build a date object from the first 3 substrings
                    DateTime date = new DateTime(year, month, day);

                    // Compare the date of the line with range of desired dates
                    if (date.CompareTo(startDate) >= 0 && date.CompareTo(endDate) <= 0)
                    {
                        // Get the other parts of the line. Open, High, Low, Close, Volume
                        double open = double.Parse(subStrings[3]);
                        double high = double.Parse(subStrings[4]);
                        double low = double.Parse(subStrings[5]);
                        double close = double.Parse(subStrings[6]);
                        long volume = long.Parse(subStrings[8]);

                        // Round the candlestick variables
                        open = Math.Round(open, 2);
                        high = Math.Round(high, 2);
                        low = Math.Round(low, 2);
                        close = Math.Round(close, 2);

                        // Create a Candlestick object and pass the arguments obtained from the loop
                        Candlestick candlestick = new Candlestick(date, open, high, low, close, volume);

                        // Add the candlestick object to the list of candlesticks
                        listOfCandlesticks.Add(candlestick);
                    }
                }
            }

            else if (header == "\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"")
            {
                // Declare char array of separators
                char[] separators = new char[] { '-', ',', '"' };

                // Create a list of candlesticks and state capacity to fit all candlesticks
                listOfCandlesticks = new List<Candlestick>(lines.Length - 1);

                // Start iterating through file until the last line
                for (int l = 1; l < lines.Length; ++l)
                {
                    // Get the lth line
                    string line = lines[l].Trim();

                    // Split it based on ',' and '-' and store it into a string array
                    string[] subStrings = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    // Parse the date info
                    int year = int.Parse(subStrings[0]);
                    int month = int.Parse(subStrings[1]);
                    int day = int.Parse(subStrings[2]);

                    // Build a date object from the first 3 substrings
                    DateTime date = new DateTime(year, month, day);

                    // Compare the date of the line with range of desired dates
                    if (date.CompareTo(startDate) >= 0 && date.CompareTo(endDate) <= 0)
                    {
                        // Get the other parts of the line. Open, High, Low, Close, Volume
                        double open = double.Parse(subStrings[3]);
                        double high = double.Parse(subStrings[4]);
                        double low = double.Parse(subStrings[5]);
                        double close = double.Parse(subStrings[6]);
                        long volume = long.Parse(subStrings[7]);

                        // Round the candlestick variables
                        open = Math.Round(open, 2);
                        high = Math.Round(high, 2);
                        low = Math.Round(low, 2);
                        close = Math.Round(close, 2);

                        // Create a Candlestick object and pass the arguments obtained from the loop
                        Candlestick candlestick = new Candlestick(date, open, high, low, close, volume);

                        // Add the candlestick object to the list of candlesticks
                        listOfCandlesticks.Add(candlestick);
                    }
                }
            }

            return listOfCandlesticks;
        }

        /// <summary>
        /// Reading stock using information provided by user method
        /// </summary>
        /// <param name="targetFilename"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="ticker"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public List<Candlestick> ReadStock(string targetFilename, DateTime startDate, DateTime endDate, string ticker, string period)
        {
            // Create the csv filename by concatenating the dataFolder, ticker, -, and .csv extension
            string csvFilename = targetFilename; // dataFolder + @"\" + ticker + "-" + period + ".csv";

            // Read the candlesticks by calling the other method and return them as a listOfCandlestick member
            listOfCandlesticks = ReadListOfCandlesticks(csvFilename, startDate, endDate);

            return listOfCandlesticks;
        }
    }
}
