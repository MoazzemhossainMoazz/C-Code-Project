public static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(MathHelper.Add(3, 4));
        Console.WriteLine(MathHelper.Multiply(3, 4));
    }
}