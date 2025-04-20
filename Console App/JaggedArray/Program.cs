public class MyClass
{
    public static void Main(string[] args)
    {
        //int[][] jaggedArray = new int[][]
        //{
        //    new int[] {1, 2 },
        //    new int[] {3, 4, 5 },
        //    new int[] {6 },
        //    new int[] {7, 8, 9, 10}
        //};
        //foreach (var row in jaggedArray)
        //{
        //    foreach (var item in row)
        //    {
        //        Console.Write($"{item}");
        //    }
        //    Console.WriteLine();
        //}

        int[][] jagged = new int[3][];

        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5, 6 };
        jagged[2] = new int[] { 7 };


        for(int i=0; i<jagged.Length; i++)
        {
            Console.Write($"Row {i}: ");
            for(int j=0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}