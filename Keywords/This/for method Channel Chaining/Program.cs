public class Counter
{
    private int count = 0;
    public Counter Increment()
    {
        count++;
        return this;
    }

    public Counter Decrement()
    {
        count--;
        return this;
    }
    public void Print()
    {
        Console.WriteLine("Count: " + count);
    }

    public static void Main()
    {
        new Counter().Increment().Increment().Decrement().Increment().Print();
    }

}
