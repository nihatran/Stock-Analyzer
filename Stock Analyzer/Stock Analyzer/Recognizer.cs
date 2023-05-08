using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Analyzer
{
    /// <summary>
    /// The abstract base class for the recognizer classes
    /// The abstract base class provides general organization and all recognition
    /// passes one or two candlesticks, needs derived class to tell if it's the pattern or not, then index is added to where pattern is found
    /// goes through list of candlesticks, form little groups, pass group of candlesticks to derived class, expects true or false
    /// </summary>
    internal abstract class Recognizer
    {
        // The name of the pattern the recognizer finds
        public string patternName { get; set; }

        // The size (in candlesticks) of the pattern the recognizer finds 
        public int patternSize { get; set; }

        /// <summary>
        /// Method that tells us if the subset matches the pattern
        /// Where the work happens
        /// </summary>
        /// <param name="subsetOfCandlesticks"></param>
        /// <returns></returns>
        protected abstract bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks);
        
        /// <summary>
        /// The generalized looping code which runs through the candlesticks and tests each subset
        /// to see if the subset matches the pattern. If it does, we add the index to the list of indices
        /// This does the work and the derived recognizers just need to provide the patternMatchesSubset() method
        /// </summary>
        /// <param name="candlesticks"></param>
        /// <returns></returns>
        public List<int> RecognizeMethod(List<Candlestick> candlesticks)
        {
            // Make a list of type int for the result
            List<int> result = new List<int>(candlesticks.Count / 8);

            // Go through the list starting at the proper index (patternSize - 1)
            int offset = patternSize - 1;
            for (int i = offset; i < candlesticks.Count; ++i) 
            {
                // Get the subset of size patternSize of candlesticks ending at index i
                List<Candlestick> subset = candlesticks.GetRange(i - offset, patternSize);

                // Now we ask to see if the subset of candles is the pattern
                // If it matches, add it to the result list
                if (patternMatchesSubset(subset))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        // The constructor using the tuples feature
        public Recognizer(string pName, int pSize) => (patternName, patternSize) = (pName, pSize);
    }
}
