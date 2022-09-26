public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words) => 
        words.Where(b => word.OrderBy(c => c).SequenceEqual(b.OrderBy(c => c))).ToList();
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Kata.Anagrams("abba", new List<string> { "aabb", "abcd", "bbaa", "dada" })));
    }
}