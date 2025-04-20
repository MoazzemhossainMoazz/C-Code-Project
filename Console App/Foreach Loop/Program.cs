//class test
//{
//    public static void Main(string[] args)
//    {
//        int[] numbers = { 1, -2, 3, 4, -5 };
//        int sum = 0;
//        foreach(int number in numbers)
//        {
//            if(number > 0)
//            {
//                Console.WriteLine(number);
//                sum += number;
//            }
//        }
//        Console.WriteLine($"The result is: {sum}");
//    }
//}

/// <summary>
//// Two Dimentional Array
/// </summary>
//class Test
//{
//    public static void Main(string[] args)
//    {
//        for(int row = 0; row < 2; row++)
//        {
//            for(int col=0; col < 3; col++)
//            {
//                Console.Write(matrix[row, col]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 4, 6, 7, 9 };
        foreach (int num in numbers)
        {
            Console.WriteLine($"{num}");

        }
    }
    
}