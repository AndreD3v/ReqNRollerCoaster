namespace ReqNRollerCoasterProject.Hooks;

using ReqNRollerCoasterProject.Support;
using Serilog.Context;
using Serilog.Events;

[Binding]
public class TestHooks
{
    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "logfiles");

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Information, outputTemplate:
                    "[{Timestamp:HH:mm:ss.fffzzz} {Level:u3}] {Message:lj}{NewLine}{Exception}")
            .WriteTo.File($"{logFilePath}/log_{DateTime.Now.ToString("yyyyMMddHHmmssff")}.log",
                rollingInterval: RollingInterval.Day,
                outputTemplate:
                    "[{Timestamp:HH:mm:ss.fffzzz} {Level:u3}] {LogScope} | {Message:lj}{NewLine}{Exception}")
            .Enrich.FromLogContext()
            .CreateLogger();

        LogContext.PushProperty("LogScope", "BeforeTestRun");
        Log.Information("Test run starting up");
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        LogContext.PushProperty("LogScope", "AfterTestRun");
        Log.Information("AfterTestRun - Test run completed");
        Log.CloseAndFlush();
    }

    [BeforeScenario]
    public static void BeforeScenario(ScenarioContext scenarioContext)
    {
        LogContext.PushProperty("LogScope", scenarioContext.ScenarioInfo.Title);
        Log.Information("BeforeScenario - Starting scenario: {LogScope}");
    }

    [AfterScenario]
    public static void AfterScenario(ScenarioContext scenarioContext)
    {
        Log.Information("AfterScenario - Completed scenario: {LogScope}");
        LogContext.Reset();
    }

    [AfterStep("@demo")]
    public static void AfterStep()
    {
        DemoHelpers.SleepForDefinedDurationForDemoPurpose();
    }
}
