using Serilog;

namespace ReqNRollerCoasterProject.Hooks
{
    [Binding]
    public class TestHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "logfiles", "log.txt");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Test run starting up");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Log.Information("Test run completed");
            Log.CloseAndFlush();
        }
    }
}
