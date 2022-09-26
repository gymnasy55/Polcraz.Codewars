using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b) {
        BigInteger.TryParse(a, out var aInt);
        BigInteger.TryParse(b, out var bInt);
        return (aInt + bInt).ToString();
    } 
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.sumStrings("1", "2"));
    }
}
