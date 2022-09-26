public class Kata
{
    public static int Find(int[] integers)
    {
        for (var i = 0; i < integers.Length - 2; i++)
        {
            if (integers[i] % 2 != integers[i + 1] % 2 && integers[i + 1] % 2 == integers[i + 2] % 2)
                return integers[i];
            if (integers[i] % 2 == integers[i + 1] % 2 && integers[i + 1] % 2 != integers[i + 2] % 2)
                return integers[i + 2];
            if (integers[i] % 2 != integers[i + 1] % 2 && integers[i] % 2 == integers[i + 2] % 2)
                return integers[i + 1];
        }
        return -1;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.Find(new[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
    }
}