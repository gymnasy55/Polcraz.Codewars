public static class Kata
{
    public static bool IsPangram(string str) => 
        str.ToLower().Where(char.IsLetter).GroupBy(ch => ch).Count() == 26;
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.IsPangram("The quick brown fox jumps over the lazy dog"));
    }
}