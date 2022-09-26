public class Kata
{
    public static int SquareDigits(int n)
    {
        var str_result = "";
        var isNegative = false;
        var _n = n.ToString();
        if (_n[0] == '-') isNegative = true;
        
        for (var i = isNegative ? 1 : 0; i < _n.Length; i++)
        {
            var temp_digit = int.Parse(_n[i].ToString());
            temp_digit *= temp_digit;
            str_result += temp_digit.ToString();
        }
        if (isNegative)
            str_result = str_result.Insert(0, "-");
        return Convert.ToInt32(str_result);
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.SquareDigits(9119));
    }
}