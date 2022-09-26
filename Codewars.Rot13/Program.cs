public class Kata
{
    public static string Rot13(string input)
    {
        var dictionary = new Dictionary<char, char>();
        for (var c = 65; c <= 97; c++)
        for (var i = 0; i < 26; i++)
            dictionary[(char)(i + c)] = (char)((i + 13) % 26 + c);
        dictionary = dictionary.Where(c => c.Key >= 97 && c.Key <= 122).ToDictionary(c => c.Key, c => c.Value);
        var result = "";
        foreach (var ch in input)
        {
            if (ch == char.ToUpper(ch) &&
                ch == char.ToUpper(dictionary.FirstOrDefault(x => x.Key == char.ToLower(ch)).Key))
                result += char.ToUpper(dictionary.First(x => x.Key == char.ToLower(ch)).Value);
            else if (ch == char.ToLower(ch) && ch == dictionary.FirstOrDefault(x => x.Key == char.ToLower(ch)).Key)
                result += dictionary.First(x => x.Key == char.ToLower(ch)).Value;
            else
                result += ch;
        }

        return result;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.Rot13("aa"));
    }
}