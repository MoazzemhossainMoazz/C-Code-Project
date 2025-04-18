class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0 && num < 120)
        {
            if (num > 25)
                Console.WriteLine("You look older than 25");
            if (num < 25)
                Console.WriteLine("You look younger than 25");
        }
        else
            Console.WriteLine("Invalid number.");

    }
}


