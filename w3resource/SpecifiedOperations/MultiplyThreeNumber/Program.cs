class MultiplyThreeNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter 1st num: ");
        int num1 =int.Parse(Console.ReadLine());

        Console.Write("Enter 2nd num: ");
        int num2 =int.Parse(Console.ReadLine());

        Console.Write("Enter 3rd num: ");
        int num3 =int.Parse(Console.ReadLine());


        Console.WriteLine($"\nThe result {num1}X{num2}X{num3} is: {num1 * num2 * num3}");
    }
}