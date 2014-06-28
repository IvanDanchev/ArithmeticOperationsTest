namespace QpcDevelopmentToolsHW
{
    using System;
    using System.Linq;

    public class SubtractionMethods
    {
        public static void SubtractInt(int startValue, int endValue)
        {
            for (int i = startValue; i > endValue;)
            {
                i--;
            }
        }

        public static void SubtractLong(long startValue, long endValue)
        {
            for (long i = startValue; i > endValue;)
            {
                i--;
            }
        }

        public static void SubtractDouble(double startValue, double endValue)
        {
            for (double i = startValue; i > endValue;)
            {
                i--;
            }
        }

        public static void SubtractFloat(float startValue, float endValue)
        {
            for (float i = startValue; i > endValue;)
            {
                i--;
            }
        }

        public static void SubtractDecimal(decimal startValue, decimal endValue)
        {
            for (decimal i = startValue; i > endValue;)
            {
                i--;
            }
        }
    }
}