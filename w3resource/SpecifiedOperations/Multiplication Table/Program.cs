class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        var num = int.Parse(Console.ReadLine());

        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}