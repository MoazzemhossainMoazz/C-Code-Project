class Prgogram
{
    static void Main()
    {
        Console.Write("Input the first number: ");
        var num1 = int.Parse(Console.ReadLine());
        Console.Write("Input the second number: ");
        var num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    }
}