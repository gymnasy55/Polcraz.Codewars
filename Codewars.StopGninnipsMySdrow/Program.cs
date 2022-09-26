public class Kata
{
    public static string SpinWords(string sentence)
    {
        string SpinWord(string word)
        {
            var result = "";
            for (var i = word.Length - 1; i >= 0; i--)
                result += word[i];
            return result;
        }

        var result = "";
        var words = sentence.Split(' ').ToList();
        for (var i = 0; i < words.Count; i++)
        {
            if (words[i].Length >= 5)
            {
                words[i] = SpinWord(words[i]);
            }
            result += words[i] + " ";
        }

        return result.Trim();
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.SpinWords("Hey fellow warriors"));
    }
}