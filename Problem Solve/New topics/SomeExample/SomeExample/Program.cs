class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        string result = ($"Name: {name}, Age: {age}");

        File.WriteAllText("info.txt", result);

        string fileContent = File.ReadAllText("info.txt");

        Console.WriteLine("File says: " + fileContent);

        string[] lines = { "Line1", "Line2", "Line3", "Line4" };
        File.WriteAllLines("lines.txt", lines);

        string[] lines2 = File.ReadAllLines("lines.txt");
        foreach(string line in lines2)
        {
            Console.WriteLine(line);
        }
    }
}