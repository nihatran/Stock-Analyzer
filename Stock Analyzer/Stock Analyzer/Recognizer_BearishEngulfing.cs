using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Analyzer
{
    /// <summary>
    /// Derived class for multi candlestick pattern
    /// Bearish Engulfing pattern
    /// If the candlestick is bearish engulfing, return true
    /// </summary>
    internal class Recognizer_BearishEngulfing : Recognizer
    {
        public Recognizer_BearishEngulfing() : base("Bearish Engulfing", 2) { }

        protected override bool patternMatchesSubset(List<Candlestick> LCS)
        {
            Candlestick previousCandlestick = LCS[0];
            Candlestick currentCandlestick = LCS[1];

            return previousCandlestick.IsBullish && currentCandlestick.IsBearish && previousCandlestick.High <= currentCandlestick.BodyTop && previousCandlestick.Low >= currentCandlestick.BodyBottom;
        }

    }

}
