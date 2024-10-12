namespace ReqNRollerCoasterProject.Support;

public static class DemoHelpers
{
    // Define a constant for the sleep duration in seconds
    private const int SleepDurationInSeconds = 1;

    // Extension method to convert seconds to milliseconds
    public static int Seconds(int seconds)
    {
        return seconds * 1000;
    }

    // Method to sleep for the defined duration
    public static void SleepForDefinedDurationForDemoPurpose()
    {
        Log.Information($"Sleeping for {SleepDurationInSeconds} seconds...");
        Thread.Sleep(Seconds(SleepDurationInSeconds));
        Console.WriteLine("Awake now!");
    }
}
