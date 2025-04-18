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


        //for (int i=0; i<count; i++)
        //{
        //    Console.Write($"Num {i + 1}: ");
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        int index = 0;
        foreach (int num in numbers)
        {
            Console.Write($"Num {index + 1}: ");
            numbers[index] = int.Parse(Console.ReadLine());
            index++;
        }

        Console.Write("\n");
        Console.Write($"\nList of numbers devided by 3: ");
        //for (int i = 0; i < count; i++)
        //{
        //    //Console.WriteLine($"Num {i + 1}: {numbers[i]}");
        //    if (numbers[i]%3 == 0)
        //    {
        //        Console.Write($"\n {numbers[i]}"); 
        //    }
        //}
        foreach(int num in numbers)
        {
            if(num%3 == 0)
            {
                Console.Write($"\n {num}");
            }
        }


        Console.Write("\n");
        Console.Write($"\nList of numbers devided by 5: ");
        //for (int i = 0; i < count; i++)
        //{
        //    if (numbers[i] % 5 == 0)
        //    {
        //        Console.Write($"\n {numbers[i]}");
        //    }
        //}
        foreach(int num in numbers)
        {
            if(num%5 == 0)
            {
                Console.Write($"\n{num}");
            }
        }



        Console.Write("\n");
        Console.Write($"\nAnother numbers are: ");
        //for (int i = 0; i < count; i++)
        //{
        //    if (numbers[i] % 3 != 0 && numbers[i] % 5 != 0)
        //    {
        //        Console.Write($"\n {numbers[i]}");
        //    }
        //}
        foreach(int num in numbers)
        {
            if(num%3 != 0 && num%5 != 0)
            {
                Console.Write($"\n {num}");
            }
        }

        Console.Write("\n\n");
    }
}