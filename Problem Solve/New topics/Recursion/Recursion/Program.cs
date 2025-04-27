//using System.Runtime.ConstrainedExecution;

//class program
//{
//    float add(float x, float y)
//    {
//        float eqAdd = x + y;
//        return eqAdd;
//    }

//    float sub(float x, float y)
//    {
//        float eqSub = x - y;
//        return eqSub;
//    }

//    float final(float x, float y)
//    {
//        float eqFinal = sub(10, 5) + add(10, 5);
//        return eqFinal;
//    }

//    static void Main(string[] args)
//    {
//        program prg = new program();
//        float result = prg.final(10, 5);

//        Console.WriteLine($"The final Result {result}");
//    }
//}


class Program
{
    int fun(int n)
    {
        if (n == 1)
            return 1;
        else
            return 1 + fun(n - 1);
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        int n = p.fun(3);
        Console.WriteLine($"The result is: {n}");
    }
}