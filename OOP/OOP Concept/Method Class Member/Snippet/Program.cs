public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Number1 = ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number2 = ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"{sum}");
    }
}