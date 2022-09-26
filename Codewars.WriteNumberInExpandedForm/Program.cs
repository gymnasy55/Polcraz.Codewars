using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
        var result = "";
        var str = num.ToString().ToCharArray();
        for (var i = str.Length - 1; i >= 0; i--)
        {
            if(char.GetNumericValue(str[str.Length - i - 1]) != 0)
                result += char.GetNumericValue(str[str.Length - i - 1]) * Math.Pow(10, i)  + " + ";
        }
      
        result = result.Remove(result.Length - 3, 3);
        return result;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.ExpandedForm(12345));
    }
}

