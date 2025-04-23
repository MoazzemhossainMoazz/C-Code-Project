//class Program
//{
//      static string RotateEnds(string ustr)
//        {
//            return ustr.Length > 1 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr; 
//        }

//    static void Main()
//    {
//        string[] testInputs = { "hello", "world", "abc", "openai", "abcdefghij", "xy"};

//        foreach(string input in testInputs)
//        {
//            string result = RotateEnds(input);
//            Console.WriteLine($"Input: {input} => Output: {result}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(testInput("W3resource"));
//        Console.WriteLine(testInput("CSharp"));
//        Console.WriteLine(testInput("x"));
//    }

//    static string testInput(string ustr)
//    {
//        return ustr.Length > 1 ? ustr.Substring(ustr.Length-1) + ustr.Substring(1,ustr.Length-2) + ustr.Substring(0, 1) : ustr;
//    }
//}

class Program
{
    static void Main()
    {
        Console.WriteLine(testInput("W3resource"));
        Console.WriteLine(testInput("CSharp"));
        Console.WriteLine(testInput("x"));
    }

    static string testInput(string ustr)
    {
        return ustr.Length > 1 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
    }
}