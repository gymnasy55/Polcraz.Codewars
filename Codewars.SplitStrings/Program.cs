public class SplitString
{
    public static string[] Solution(string str)
    {
        void AddString(ref List<string> a, int n)
        {
            for(var i = 0; i < n - 1; i += 2)
                a.Add(str[i] + str[i + 1].ToString());
        }
        var strings = new List<string>();
        if(str.Length % 2 == 0)
            AddString(ref strings, str.Length);
        else
        {
            AddString(ref strings, str.Length - 1);
            strings.Add(str[str.Length - 1] + "_");
        }

        return strings.ToArray();
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", SplitString.Solution("abc")));
    }
}