public class Logger
{
    static Logger()
    {
        Console.WriteLine("Logger Initialized (Static Constructor)");
    }

    public static void Log(string messege)
    {
        Console.WriteLine("Log: " + messege);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger.Log("Application started.");
        Logger.Log("Something happened");
    }
}