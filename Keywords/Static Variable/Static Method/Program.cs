public class Calculator
{
    public static  int Square(int n)
    {
        return n * n;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Calculator.Square(5));
    }
}