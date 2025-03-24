
//Top level Statement, When I don't use main method
var Pay = new CreditCardPayment();
Pay.ProcessPayment();

var pay = new PayPalPayment();
pay.ProcessPayment();


abstract class Payment
{
    public abstract void ProcessPayment();
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment.");
    }
}

class PayPalPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal Payment");

    }
}

//class Program
//{
//    static void Main()
//    {
//        Payment pay = new CreditCardPayment();
//        Payment Pay1 = new PayPalPayment();

//        pay.ProcessPayment();
//            Pay1.ProcessPayment();
//    }
//}
