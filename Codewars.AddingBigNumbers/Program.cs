public class Kata
{
    public static string Add(string a, string b)
    {
        var _a = a.ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray();
        var _b = b.ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray();
        var result = new List<int>();
        var _aSize = _a.Length;
        var _bSize = _b.Length;
        var temp1 = 0;
        for (var i = 0; i < Math.Max(_a.Length, _b.Length); i++)
        {
            var temp2 = 0;
            if (_aSize > 0)
                temp2 += _a[_aSize - 1];
            if (_bSize > 0)
                temp2 += _b[_bSize - 1];
            temp2 += temp1;
            temp1 = temp2 / 10;
            temp2 %= 10;
            result.Insert(0, temp2);
            _aSize--;
            _bSize--;
        }
        if (temp1 != 0)
            result.Insert(0, temp1);
        return string.Join("", result);
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.Add("1", "9"));
    }
}