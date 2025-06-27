using System.Net.Http.Headers;

abstract class PaymentMethod
{
    public abstract void Pay(decimal amount);
}

class BkashPayment : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} via Bkash.");
    }
}

class CreditCardPayment : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} via Credit Card.");
    }
}

class Program
{
    static void ProcessPayment(PaymentMethod payment, decimal amount)
    {
        payment.Pay(amount);
    }

    static void Main()
    {
        PaymentMethod p1 = new BkashPayment();
        PaymentMethod p2 = new CreditCardPayment();

        ProcessPayment(p1, 1000);
        ProcessPayment(p2, 2000);
    }
}