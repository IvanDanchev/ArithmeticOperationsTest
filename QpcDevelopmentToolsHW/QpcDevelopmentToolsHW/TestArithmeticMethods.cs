namespace QpcDevelopmentToolsHW
{
    using System;
    using System.Linq;
    using log4net;
    using log4net.Config;
    using log4net.Appender;
    using log4net.Layout;

    public class TestArithmeticMethods
    {
        private static readonly ILog Log =
            LogManager.GetLogger(typeof(TestArithmeticMethods));

        public static void Main(string[] args)
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "log.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.ActivateOptions();
            BasicConfigurator.Configure(fileAppender);

            Log.Info("Entering application.");

            AdditionMethods.AddInt(1, 700000);
            AdditionMethods.AddLong(1L, 700000L);
            AdditionMethods.AddDecimal(1m, 700000m);
            AdditionMethods.AddDouble(1d, 700000d);
            AdditionMethods.AddFloat(1f, 700000f);

            SubtractionMethods.SubtractInt(700000, 1);
            SubtractionMethods.SubtractLong(700000L, 1L);
            SubtractionMethods.SubtractDecimal(700000m, 1m);
            SubtractionMethods.SubtractDouble(700000d, 1d);
            SubtractionMethods.SubtractFloat(700000f, 1f);

            MultiplicationMethods.MultiplyInt(2, 700000, 5);
            MultiplicationMethods.MultiplyLong(2L, 700000L, 5L);
            MultiplicationMethods.MultiplyDecimal(2m, 700000m, 2m);
            MultiplicationMethods.MultiplyDouble(2d, 700000d, 5d);
            MultiplicationMethods.MultiplyFloat(2f, 700000f, 5f);

            DivisionMethods.DivideInt(700000, 2, 2);
            DivisionMethods.DivideLong(700000L, 2L, 2L);
            DivisionMethods.DivideDecimal(700000m, 2m, 2m);
            DivisionMethods.DivideDouble(700000d, 2d, 2d);
            DivisionMethods.DivideFloat(700000f, 2f, 2f);

            Log.Info("Exiting application.");
        }
    }
}
