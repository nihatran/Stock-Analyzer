using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Analyzer
{
    /// <summary>
    /// Derived classes of Recognizer, the abstract class
    /// Each single candlestick pattern is its own class
    /// Each recognizer provides patternMatchesSubset method that tells Recognizer if it is a pattern or not
    /// </summary>
    internal class SingleCandlestickRecognizers
    {
        /// <summary>
        /// Bullish recognizer
        /// </summary>
        internal class Recognizer_Bullish : Recognizer
        {
            public Recognizer_Bullish() : base("Bullish", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBullish;
            }
        }

        /// <summary>
        /// Bearish recognizer
        /// </summary>
        internal class Recognizer_Bearish : Recognizer
        {
            public Recognizer_Bearish() : base("Bearish", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBearish;
            }
        }

        /// <summary>
        /// Neutral recognizer
        /// </summary>
        internal class Recognizer_Neutral : Recognizer
        {
            public Recognizer_Neutral() : base("Neutral", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsNeutral;
            }

        }

        /// <summary>
        /// Doji recognizer
        /// </summary>
        internal class Recognizer_Doji : Recognizer
        {
            public Recognizer_Doji() : base("Doji", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsDoji;
            }
        }

        /// <summary>
        /// Dragonfly Doji recognizer
        /// </summary>
        internal class Recognizer_DragonflyDoji : Recognizer
        {
            public Recognizer_DragonflyDoji() : base("Dragonfly Doji", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsDragonflyDoji;
            }
        }

        /// <summary>
        /// Gravestone Doji recognizer
        /// </summary>
        internal class Recognizer_GravestoneDoji : Recognizer
        {
            public Recognizer_GravestoneDoji() : base("Gravestone Doji", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsGravestoneDoji;
            }
        }

        /// <summary>
        /// Long Legged Doji recognizer
        /// </summary>
        internal class Recognizer_LongLeggedDoji : Recognizer
        {
            public Recognizer_LongLeggedDoji() : base("Long Legged Doji", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsLongLeggedDoji;
            }
        }

        /// <summary>
        /// Neutral Doji recognizer
        /// </summary>
        internal class Recognizer_NeutralDoji : Recognizer
        {
            public Recognizer_NeutralDoji() : base("Neutral Doji", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsNeutralDoji;
            }
        }

        /// <summary>
        /// Marubozu recognizer
        /// </summary>
        internal class Recognizer_Marubozu : Recognizer
        {
            public Recognizer_Marubozu() : base("Marubozu", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsMarubozu;
            }
        }

        /// <summary>
        /// Black Marubozu recognizer
        /// </summary>
        internal class Recognizer_BlackMarubozu : Recognizer
        {
            public Recognizer_BlackMarubozu() : base("Black Marubozu", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBlackMarubozu;
            }
        }

        /// <summary>
        /// White Marubozu recognizer
        /// </summary>
        internal class Recognizer_WhiteMarubozu : Recognizer
        {
            public Recognizer_WhiteMarubozu() : base("White Marubozu", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsWhiteMarubozu;
            }
        }

        /// <summary>
        /// Hammer recognizer
        /// </summary>
        internal class Recognizer_Hammer : Recognizer
        {
            public Recognizer_Hammer() : base("Hammer", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsHammer;
            }
        }

        /// <summary>
        /// Bullish Hammer recognizer
        /// </summary>
        internal class Recognizer_BullishHammer : Recognizer
        {
            public Recognizer_BullishHammer() : base("Bullish Hammer", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBullishHammer;
            }
        }

        /// <summary>
        /// Bearish Hammer recognizer
        /// </summary>
        internal class Recognizer_BearishHammer : Recognizer
        {
            public Recognizer_BearishHammer() : base("Bearish Hammer", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBearishHammer;
            }
        }

        /// <summary>
        /// Inverted Hammer Recognizer
        /// </summary>
        internal class Recognizer_InvertedHammer : Recognizer
        {
            public Recognizer_InvertedHammer() : base ("Inverted Hammer", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsInvertedHammer;
            }
        }

        /// <summary>
        /// Bullish Inverted Hammer Recognizer
        /// </summary>
        internal class Recognizer_BullishInvertedHammer : Recognizer
        {
            public Recognizer_BullishInvertedHammer() : base("Bullish Inverted Hammer", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBullishInvertedHammer;
            }
        }

        /// <summary>
        /// Bearish Inverted Hammer Recognizer
        /// </summary>
        internal class Recognizer_BearishInvertedHammer : Recognizer
        {
            public Recognizer_BearishInvertedHammer() : base("Bearish Inverted Hammer", 1) { }
            protected override bool patternMatchesSubset(List<Candlestick> subsetOfCandlesticks)
            {
                return subsetOfCandlesticks[0].IsBearishInvertedHammer;
            }
        }
    }
}
