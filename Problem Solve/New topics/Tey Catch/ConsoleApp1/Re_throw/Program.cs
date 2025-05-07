class Program
{
    static void Main()
    {
        try
        {
            ProcessData();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught in main: ", ex.Message);
        }
    }

    static void ProcessData()
    {
        try
        {
            int[] data = new int[2];
            Console.WriteLine(data[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Logging: ", ex.Message);
            throw;
        }
    }
}