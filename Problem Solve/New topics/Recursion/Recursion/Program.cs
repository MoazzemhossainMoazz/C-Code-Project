using System.Runtime.ConstrainedExecution;

class program
{
    float add(float x, float y)
    {
        float eqAdd = x + y;
        return eqAdd;
    }

    float sub(float x, float y)
    {
        float eqSub = x - y;
        return eqSub;
    }

    float final(float x, float y)
    {
        float eqFinal = sub(10, 5) + add(10, 5);
        return eqFinal;
    }
  
    static void Main(string[] args)
    {
        program prg = new program();
        float result = prg.final(10, 5);

        Console.WriteLine($"The final Result {result}");
    }
}