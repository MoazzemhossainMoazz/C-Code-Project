using System.Data;

class SpecifiedOperation
{
    static void Main(string[] args)
    {
        //string str = "4/5*6-5";

        //System.Console.WriteLine(str);

        Console.WriteLine("Enter a arithmatic expression: ");
        string expression =Console.ReadLine();

        var result = new DataTable().Compute(expression, null);
        System.Console.WriteLine(result);
    }
}