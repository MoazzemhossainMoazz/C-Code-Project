// C# program to illustrate the
// String.Split() Method 
using System;

class Geeks
{
    public static void Main()
    {
        // declaring the string
        String str = "Hello from GeeksforGeeks";

        // Splitting the string
        // into substrings separated by spaces
        string[] split = str.Split(' ');

        foreach (var word in split)
        {
            Console.WriteLine(word);
        }
    }
}
