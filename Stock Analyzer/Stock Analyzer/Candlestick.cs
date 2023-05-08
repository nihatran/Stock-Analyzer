using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Analyzer
{
    /// <summary>
    /// Member variables of candlestick class, constructors, properties of candlestick, single candlestick patterns,
    /// tests for each candlestick pattern, computeProperties method, computePatterns method
    /// Properties of the candlestick is in the Candlestick class so that everything is calculated once. Efficient. 
    /// </summary>
    public class Candlestick
    {
        // Member variables of candlestick class
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public long Volume { get; set; }

        // Default constructor
        public Candlestick()
        {
            Date = DateTime.Now;
            Open = 0;
            High = 0;
            Low = 0;
            Close = 0;
            Volume = 0;
        }

        // Copy constructor
        public Candlestick(Candlestick cs)
        {
            Date = cs.Date;
            Open = cs.Open;
            High = cs.High;
            Low = cs.Low;
            Close = cs.Close;
            Volume = cs.Volume;
        }

        // Parameter constructor
        public Candlestick(DateTime aDate, double aOpen, double aHigh, double aLow, double aClose, long aVolume)
        {
            Date = aDate;
            Open = aOpen;
            High = aHigh;
            Low = aLow;
            Close = aClose;
            Volume = aVolume;

            computeProperties();
        }

        // Properties of the candlestick
        public double Body { get; private set; }

        public double Range { get; private set; }

        public double UpperTail { get; private set; }

        public double LowerTail { get; private set; }

        public double BodyTop { get; private set; } // topPrice

        public double BodyBottom { get; private set; } // bottomPrice


        /// <summary>
        /// Single candlestick patterns, member variables that return true or false
        /// </summary>

        // Bullish, Bearish, Neutral properties
        public bool IsBullish { get; private set; }

        public bool IsBearish { get; private set; }

        public bool IsNeutral { get; private set; }

        // Different types of dojis
        public bool IsDoji { get; private set; }

        public bool IsDragonflyDoji { get; private set; }

        public bool IsGravestoneDoji { get; private set; }

        public bool IsLongLeggedDoji { get; private set; }

        public bool IsNeutralDoji { get; private set; }

        // Different types of marubozus
        public bool IsMarubozu { get; private set; }

        public bool IsBlackMarubozu { get; private set; }

        public bool IsWhiteMarubozu { get; private set; }

        // Different types of hammers
        public bool IsHammer { get; private set; }

        public bool IsBullishHammer { get; private set; }

        public bool IsBearishHammer { get; private set; }

        public bool IsInvertedHammer { get; private set; }

        public bool IsBullishInvertedHammer { get; private set; }

        public bool IsBearishInvertedHammer { get; private set; }

        
        // Tests for each candlestick pattern

        /// <summary>
        /// Doji test
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <returns></returns>
        public bool DojiTest(double bodyTolerance = 0.03)
        {
            return Body <= bodyTolerance * Range;
        }

        /// <summary>
        /// Dragonfly Doji test
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <param name="upperTailTolerance"></param>
        /// <returns></returns>
        public bool DragonflyDojiTest(double bodyTolerance = 0.03, double upperTailTolerance = 0.3)
        {
            return DojiTest(bodyTolerance) && (UpperTail <= upperTailTolerance * Range);
        }

        /// <summary>
        /// Gravestone Doji test
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <param name="lowerTailTolerance"></param>
        /// <returns></returns>
        public bool GravestoneDojiTest(double bodyTolerance = 0.03, double lowerTailTolerance = 0.3)
        {
            return DojiTest(bodyTolerance) && (LowerTail <= lowerTailTolerance * Range);
        }

        /// <summary>
        /// Long Legged Doji test
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <param name="upperTailTolerance"></param>
        /// <param name="lowerTailTolerance"></param>
        /// <returns></returns>
        public bool LongLeggedDojiTest(double bodyTolerance = 0.03, double upperTailTolerance = 0.4, double lowerTailTolerance = 0.4)
        {
            return DojiTest() && UpperTail > upperTailTolerance * Range && LowerTail > lowerTailTolerance * Range;
        }

        /// <summary>
        /// Neutral Doji test
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <returns></returns>
        public bool NeutralDojiTest(double bodyTolerance = 0.03)
        {
            return DojiTest(bodyTolerance) && UpperTail == LowerTail;
        }

        /// <summary>
        /// Marubozu test
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <returns></returns>
        public bool MarubozuTest(double bodyTolerance = 0.9)
        {
            return Body > bodyTolerance * Range; 
        }

        /// <summary>
        /// Black Marubozu test
        /// </summary>
        /// <returns></returns>
        public bool BlackMarbubozuTest()
        {
            return IsMarubozu && IsBearish;
        }

        /// <summary>
        /// White Marubozu test
        /// </summary>
        /// <returns></returns>
        public bool WhiteMarubozuTest()
        {
            return IsMarubozu && IsBullish;
        }

        /// <summary>
        /// Hammer test
        /// </summary>
        /// <param name="upperBodyTolerance"></param>
        /// <param name="lowerBodyTolerance"></param>
        /// <param name="upperTailTolerance"></param>
        /// <returns></returns>
        public bool HammerTest(double upperBodyTolerance = 0.3, double lowerBodyTolerance = 0.1, double upperTailTolerance = 0.2)
        {
            return BullishHammerTest(upperBodyTolerance, lowerBodyTolerance, upperTailTolerance) || BearishHammerTest(upperBodyTolerance, lowerBodyTolerance, upperTailTolerance);
        }

        /// <summary>
        /// Bullish Hammer test
        /// </summary>
        /// <param name="upperBodyTolerance"></param>
        /// <param name="lowerBodyTolerance"></param>
        /// <param name="upperTailTolerance"></param>
        /// <returns></returns>
        public bool BullishHammerTest(double upperBodyTolerance = 0.3, double lowerBodyTolerance = 0.1, double upperTailTolerance = 0.2)
        {
            return Body < upperBodyTolerance * Range && Body > lowerBodyTolerance * Range && IsBullish && UpperTail < upperTailTolerance * Range;
        }

        /// <summary>
        /// Bearish Hammer test
        /// </summary>
        /// <param name="upperBodyTolerance"></param>
        /// <param name="lowerBodyTolerance"></param>
        /// <param name="upperTailTolerance"></param>
        /// <returns></returns>
        public bool BearishHammerTest(double upperBodyTolerance = 0.3, double lowerBodyTolerance = 0.1, double upperTailTolerance = 0.2)
        {
            return Body < upperBodyTolerance * Range && Body > lowerBodyTolerance * Range && IsBearish && UpperTail < upperTailTolerance * Range;
        }

        /// <summary>
        /// Inverted Hammer test
        /// </summary>
        /// <param name="upperBodyTolerance"></param>
        /// <param name="lowerBodyTolerance"></param>
        /// <param name="lowerTailTolerance"></param>
        /// <returns></returns>
        public bool InvertedHammerTest(double upperBodyTolerance = 0.3, double lowerBodyTolerance = 0.1, double lowerTailTolerance = 0.2)
        {
            return IsBullishInvertedHammerTest(upperBodyTolerance, lowerBodyTolerance, lowerTailTolerance) || IsBearishInvertedHammerTest(upperBodyTolerance, lowerBodyTolerance, lowerTailTolerance);
        }

        /// <summary>
        /// Bullish Inverted Hammer test
        /// </summary>
        /// <param name="upperBodyTolerance"></param>
        /// <param name="lowerBodyTolerance"></param>
        /// <param name="lowerTailTolerance"></param>
        /// <returns></returns>
        public bool IsBullishInvertedHammerTest(double upperBodyTolerance = 0.3, double lowerBodyTolerance = 0.1, double lowerTailTolerance = 0.2)
        {
            return Body < upperBodyTolerance * Range && Body > lowerBodyTolerance * Range && IsBullish && LowerTail < lowerTailTolerance * Range;
        }

        /// <summary>
        /// Bearish Inverted Hammer test
        /// </summary>
        /// <param name="upperBodyTolerance"></param>
        /// <param name="lowerBodyTolerance"></param>
        /// <param name="lowerTailTolerance"></param>
        /// <returns></returns>
        public bool IsBearishInvertedHammerTest(double upperBodyTolerance = 0.3, double lowerBodyTolerance = 0.1, double lowerTailTolerance = 0.2)
        {
            return Body < upperBodyTolerance * Range && Body > lowerBodyTolerance * Range && IsBearish && LowerTail < lowerTailTolerance * Range;
        }

        /// <summary>
        /// Compute properties method
        /// calculates the range, body, upper tail, lower tail, body top, body bottom
        /// calls computePatterns method
        /// </summary>
        private void computeProperties()
        {
            Range = High - Low;
            Body = Math.Max(Open, Close) - Math.Min(Open, Close);
            UpperTail = High - Math.Max(Open, Close);
            LowerTail = Math.Min(Open, Close) - Low;
            BodyTop = Math.Max(Open, Close);
            BodyBottom = Math.Min(Open, Close);

            computePatterns();
        }

        /// <summary>
        /// Compute patterns method
        /// </summary>
        private void computePatterns()
        {
            // General properties
            IsBullish = Close > Open;
            IsBearish = Close < Open;
            IsNeutral = Close == Open;

            // Doji computations
            IsDoji = DojiTest();
            IsDragonflyDoji = DragonflyDojiTest();
            IsGravestoneDoji = GravestoneDojiTest();
            IsLongLeggedDoji = LongLeggedDojiTest();
            IsNeutralDoji = NeutralDojiTest();

            // Marubozu computations
            IsMarubozu = MarubozuTest();
            IsBlackMarubozu = BlackMarbubozuTest();
            IsWhiteMarubozu = WhiteMarubozuTest();

            // Hammer computations 
            IsHammer = HammerTest();
            IsBullishHammer = BullishHammerTest();
            IsBearishHammer = BearishHammerTest();
            IsInvertedHammer = InvertedHammerTest();
            IsBullishInvertedHammer = IsBullishInvertedHammerTest();
            IsBearishInvertedHammer = IsBearishInvertedHammerTest();

        }

    }

}
