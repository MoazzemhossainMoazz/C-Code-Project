class Program
{
    public static void Main()
    {
        void PrintIfInt(object val)
        {
            if(val is int i)
            {
                Console.WriteLine($"Integer value: {i}");
            }
            else
            {
                Console.WriteLine($"Not a integer value");
            }
        }

        PrintIfInt(123);
        PrintIfInt("Hello");
        PrintIfInt(4.2);
        PrintIfInt("123abc");
    }
}