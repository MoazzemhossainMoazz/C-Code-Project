//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter how many numbers you want to input: ");
//        int count = int.Parse(Console.ReadLine());
//        int[] numbers = new int[count];
//        for (int i = 0; i < count; i++)
//        {
//            Console.Write($"Enter number {i + 1}: ");
//            numbers[i] = int.Parse(Console.ReadLine());
//        }
//        foreach (int num in numbers)
//        //for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine($"The number is: {num}");
//            //Console.WriteLine($"Inputed number is {i + 1}: {numbers[i]}");
//        }
//    }
//}

class Program
{
    static void Main()
    {
        Console.Write("How many numbers do you want to input:  ");
        int count = int.Parse(Console.ReadLine());

        int[] numbers = new int[count];

        for (int i=0; i<count; i++)
        {
            Console.Write($"Num {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n");
        Console.Write($"\nList of numbers devided by 3: ");
        for (int i = 0; i < count; i++)
        {
            //Console.WriteLine($"Num {i + 1}: {numbers[i]}");
            if (numbers[i]%3 == 0)
            {
                Console.Write($"\n {numbers[i]}"); 
            }
        }

        Console.Write("\n");
        Console.Write($"\nList of numbers devided by 5: ");
        for (int i = 0; i < count; i++)
        {
            if (numbers[i] % 5 == 0)
            {
                Console.Write($"\n {numbers[i]}");
            }
        }

        Console.Write("\n");
        Console.Write($"\nAnother numbers are: ");
        for (int i = 0; i < count; i++)
        {
            if (numbers[i] % 3 != 0 && numbers[i] % 5 != 0)
            {
                Console.Write($"\n {numbers[i]}");
            }
        }
        Console.Write("\n\n");
    }
}