public class Number
{
    public long DigitalRoot(long n) => (n - 1) % 9 + 1;
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(new Number().DigitalRoot(15));
    }
}