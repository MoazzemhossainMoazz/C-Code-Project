class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to input: ");
        int count = int.Parse(Console.ReadLine());

        int[] numbers = new int[count];


        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (int num in numbers)
        //for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"The number is: {num}");
            //Console.WriteLine($"Inputed number is {i + 1}: {numbers[i]}");
        }


    }
}