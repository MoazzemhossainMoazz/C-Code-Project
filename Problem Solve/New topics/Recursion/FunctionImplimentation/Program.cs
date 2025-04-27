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

    float mul(float x, float y)
    {
        float eqMul = x * y;
        return eqMul;
    }

    float div(float x, float y)
    {
        float eqDiv = x / y;
        return eqDiv;
    }

    float karli(float x, float y)
    {
        float eqKarli = sub(10, 5) + add(10, 5);
        return eqKarli;
    }

    float sqrt(float x, float y)
    {
        float eqSqrt = mul(10, 5) + karli(10, 5);
        return eqSqrt;
    }

    float final(float x, float y)
    {
        float eqFinal = div(10, 5) + sqrt(10, 5);
        return eqFinal;
    }
    static void Main(string[] args)
    {
        program prg = new program();
        float result = prg.final(10, 5);

        Console.WriteLine($"The final Result {result}");
    }
}