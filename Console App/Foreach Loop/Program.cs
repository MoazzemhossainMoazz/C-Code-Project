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

public class MyClass
{
    public static void Main(string[] args)
    {
        int[][] jaggedArray = new int[][]
        {
            new int[] {1, 2 },
            new int[] {3, 4, 5 },
            new int[] {6 },
            new int[] {7, 8, 9, 10}
        };
        foreach(var row in jaggedArray)
        {
            foreach(var item in row)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
        }
    }
}