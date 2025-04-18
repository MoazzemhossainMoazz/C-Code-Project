class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter the first number: ");
        //var num1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter the second number: ");
        //var num2 = int.Parse(Console.ReadLine());
        //Console.Write("Enter the third number: ");
        //var num3 = int.Parse(Console.ReadLine());
        //Console.Write("Enter the fourth number: ");
        //var num4 = int.Parse(Console.ReadLine());

        //Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {(num1 + num2 + num3 + num4) / 4}");

        Console.WriteLine("Enter how many number do you want: ");
        int count = int.Parse(Console.ReadLine());

        int[] numbers = new int[count];
        int sum = 0;
        for(int i =0; i<count; i++)
        {
            Console.Write($"Enter num{i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            sum = sum + numbers[i];
        }

        Console.WriteLine($"The average number is: {sum / count}");
    }
}