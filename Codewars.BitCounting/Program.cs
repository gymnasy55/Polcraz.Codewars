public class Kata
{
    public static int CountBits(int n)
    {
        var count = 0;
        while (n != 0)
        {
            count++;
            n &= n - 1;
        }
        return count;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.CountBits(7));
    }
}