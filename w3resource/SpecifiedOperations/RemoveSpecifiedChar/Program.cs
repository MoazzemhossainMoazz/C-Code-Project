class RemoveChar
{
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
    static void Main()
    {
        Console.WriteLine(remove_char("w3resource", 1));
        Console.WriteLine(remove_char("w3resource", 5));
        Console.WriteLine(remove_char("w3resource", 9));
    }
}