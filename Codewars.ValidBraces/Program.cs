public class Brace
{
    public static bool validBraces(String braces)
    {
        while (braces.IndexOf("{}", StringComparison.Ordinal) != -1 ||
               braces.IndexOf("()", StringComparison.Ordinal) != -1 ||
               braces.IndexOf("[]", StringComparison.Ordinal) != -1)
        {
            braces = braces.Replace("{}", "").Replace("()", "").Replace("[]", "");
        }

        return braces.Length == 0;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Brace.validBraces("[{()}]"));
    }
}