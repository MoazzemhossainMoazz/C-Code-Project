class SwapNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Number 1: ");
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2: ");
        var num2 =int.Parse(Console.ReadLine());


        Console.WriteLine("\nInputed number is: ");
        Console.WriteLine($"Num1: {num1}");
        Console.WriteLine($"Num2: {num2}");

        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\nAfter the swapping numbers: ");
        Console.WriteLine($"Num1: {num1}");
        Console.WriteLine($"Num2: {num2}");
        

    }
}