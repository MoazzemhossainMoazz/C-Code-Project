public class Program
{
    public static void Main()
    {
        string? message = null;

        if (message == null)
            Console.WriteLine("Message is null.");
        else
            Console.WriteLine("Message" + message);

        int? value = null;
        Console.WriteLine("Value is zero: " + (value ?? 0));
    }
}