namespace LibLogWithSerilogSample
{
    using ConsoleApplication7.Logging;
    using Serilog;

    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().ReadAppSettings().CreateLogger();

            var logger = LogProvider.GetCurrentClassLogger();
            logger.Debug(() => "write value to log.");
        }
    }
}