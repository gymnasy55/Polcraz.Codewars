public class CustomMath 
{
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(CustomMath.multiply(5, 4));
    }
}