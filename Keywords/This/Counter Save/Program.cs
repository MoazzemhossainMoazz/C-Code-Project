public class Counter
{
    public int count = 0;
    public const string filePath = "Counter2.txt";

    public void Increment()
    {
        count++;
        Console.Write($"Increment. Count: {count}\n");
    }

    public void Decrement()
    {
        if(count > 0)
        {
            count--;
            Console.Write($"Decrement. Count:{count}\n");
        }
        else
        {
            Console.WriteLine("Decrement is not possible");
        }
    }

    public void Print()
    {
        Console.WriteLine($"Show the value is: {count}");
    }

    public void Reset()
    {
        count = 0;
        Console.Write($"Reset Successfully. Count: {count}");
    }

    public  void Save()
    {
        File.WriteAllText(filePath, count.ToString());
        Console.WriteLine("Save Successfully");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Counter count = new Counter();

        while (true)
        {
            Console.WriteLine("\n\nChoose a option.");
            Console.WriteLine("1. Increment\n2. Decrement\n3. Show\n4. Reset\n5. Save.");
            Console.Write("Choose: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": count.Increment(); break;
                case "2": count.Decrement(); break;
                case "3": count.Print(); break;
                case "4": count.Reset(); break;
                case "5": count.Save(); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}