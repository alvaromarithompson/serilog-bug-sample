using Serilog;

namespace SerilogSample
{
    public class Test : ITest
    {
        private readonly ILogger logger;

        public Test(ILogger logger)
        {
            this.logger = logger;
        }

        public void DoTest()
        {
            logger.Information("This is a log line from a class.");
        }
    }
}
