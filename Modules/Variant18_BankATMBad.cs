namespace ReviewSamples.Modules.Variants;

public class BankATM
{
    public double b = 1000;
    public string p = "1234";

    public double W(double a)
    {
        Console.WriteLine("PIN: " + p);
        if (a > b)
        {
            return -1;
        }
        b = b - a;
        Console.WriteLine("Balance: " + b);
        return b;
    }

    public double D(double a)
    {
        b = b + a;
        Console.WriteLine("Balance: " + b);
        return b;
    }

    public double GetBalance()
    {
        return b;
    }
}