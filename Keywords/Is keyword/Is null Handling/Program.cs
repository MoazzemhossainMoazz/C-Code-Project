class Program
{
    static void Main()
    {
        object x = null;

        if(x is string)
        {
            Console.WriteLine("It's a string.");
        }

        else
        {
            Console.WriteLine("It's null or not a string.");
        }
    }
}