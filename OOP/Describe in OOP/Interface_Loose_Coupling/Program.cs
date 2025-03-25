interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }
    public void Run()
    {
        _logger.Log("Application started");
    }
}

class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        Application app = new Application(logger);
        app.Run();
    }
}