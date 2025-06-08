public class AppConfig
{
    public static readonly string Version;

    static AppConfig()
    {
        Version = "1.0.0";
        Console.WriteLine("AppConfig intialized: " + Version);

    }

    
}

class Program
{
    static void Main()
    {
            Console.WriteLine("App version: " + AppConfig.Version);
    }
}