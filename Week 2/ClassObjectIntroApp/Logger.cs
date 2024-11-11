public class Logger
{
    public static string LogFilePath;

    // Static constructor
    static Logger()
    {
        LogFilePath = "default.log";
        Console.WriteLine("Static constructor called");
    }
}
