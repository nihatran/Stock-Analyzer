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
    /// Bullish Engulfing pattern
    /// If the candlestick is bullish engulfing, return true
    /// </summary>
    internal class Recognizer_BullishEngulfing : Recognizer
    {
        public Recognizer_BullishEngulfing() : base("Bullish Engulfing", 2) { }

        protected override bool patternMatchesSubset(List<Candlestick> LCS)
        {
            Candlestick previousCandlestick = LCS[0];
            Candlestick currentCandlestick = LCS[1];

            return previousCandlestick.IsBearish && currentCandlestick.IsBullish && previousCandlestick.High <= currentCandlestick.BodyTop && previousCandlestick.Low >= currentCandlestick.BodyBottom;
        }

    }

}
